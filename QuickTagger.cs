using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using static MusicBeePlugin.Plugin;
using System.IO;
using System.Linq;
using System.Xml;

namespace MusicBeePlugin
{
    public partial class QuickTagger
    {
        // List of tags that should have values appended
        private static readonly MetaDataType[] AppendableTags =
        {
            MetaDataType.Comment, // Example, add other MetaDataType values as needed
            MetaDataType.Genre,
            MetaDataType.Mood,
            MetaDataType.Occasion
        };

        public QuickTagger()
        {
            PluginSettings.LoadSettings();
        }

        public void ShowConfiguration(Action afterCloseFn = null)
        {
            ConfigurationForm configForm = new ConfigurationForm(tags =>
            {
                PluginSettings.Settings.Tags.Clear();
                foreach (var tag in tags)
                {
                    if (string.IsNullOrEmpty(tag.value) || tag.code == -1)
                    {
                        continue;
                    }
                    PluginSettings.Settings.Tags.Add((MetaDataType)tag.code, string.Join(", ", tag.value.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x))));
                }
                PluginSettings.SaveSettings();
            });
            configForm.ShowDialog();
            afterCloseFn?.Invoke();
            Api.MB_RefreshPanels();
        }

        public void SetTag_handle(MetaDataType tag, string value)
        {
            QueryMusics(musics =>
            {
                foreach (var music in musics)
                {
                    ChangeFileTag(music, tag, value);
                }
                Api.MB_RefreshPanels();
            });
        }

        public void SetTagCustom_handle(MetaDataType tag)
        {
            QueryMusics(musics =>
            {
                var tagName = GetTagName(tag);
                CustomValueForm valueForm = new CustomValueForm(musics.Length == 1 ? Api.Library_GetFileTag(musics[0], tag) : "", tagName, value =>
                {
                    foreach (var music in musics)
                    {
                        ChangeFileTag(music, tag, value);
                    }
                    Api.MB_RefreshPanels();
                });
                valueForm.ShowDialog();
            });
        }

        private void ChangeFileTag(string fileUrl, MetaDataType tag, string newValue)
        {
            var priorityWords = new List<string>();

            // Retrieve the existing tag value
            string existingValue = Api.Library_GetFileTag(fileUrl, tag);
            string updatedValue;

            if (AppendableTags.Contains(tag))
            {
                List<string> tagList = existingValue?.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToList() ?? new List<string>();
                if (tagList.Contains(newValue.Trim()))
                {
                    tagList.Remove(newValue.Trim());
                }
                else
                {
                    tagList.Add(newValue.Trim());
                }

                // Read priority words from the settings configuration
                var xmlPriorityWords = PluginSettings.Settings.PriorityWords;

                // Combine the settings priority words with the existing priority words
                priorityWords.AddRange(xmlPriorityWords);

                // Separate the priority and non-priority tags
                var priorityTags = tagList.Where(x => priorityWords.Contains(x)).ToList();
                var nonPriorityTags = tagList.Where(x => !priorityWords.Contains(x)).ToList();

                // Sort the priority tags based on their priority
                priorityTags.Sort((x, y) => priorityWords.IndexOf(x).CompareTo(priorityWords.IndexOf(y)));

                // Combine the sorted priority tags with the non-priority tags
                var sortedTagList = priorityTags.Concat(nonPriorityTags).ToList();

                updatedValue = string.Join(", ", sortedTagList);
            }
            else
            {
                if (existingValue.Trim().Equals(newValue.Trim()))
                {
                    updatedValue = string.Empty;
                }
                else
                {
                    updatedValue = newValue.Trim();
                }
            }

            // Set the new value
            Api.Library_SetFileTag(fileUrl, tag, updatedValue);
            Api.Library_CommitTagsToFile(fileUrl);
        }

        private string[] GetSelectedMusics()
        {
            string[] selectedMusics = null;
            Api.Library_QueryFilesEx("domain=SelectedFiles", out selectedMusics);
            var playingMusic = Api.NowPlaying_GetFileUrl();
            return selectedMusics == null ? playingMusic != null ? new string[] { playingMusic } : new string[] { } : selectedMusics;
        }

        private void QueryMusics(Action<string[]> processFn)
        {
            var musics = GetSelectedMusics();
            if (musics.Length > 20)
            {
                var promptResult = MessageBox.Show("Are you sure you want to change tag of " + musics.Length + " musics?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (promptResult != DialogResult.Yes)
                {
                    return;
                }
            }
            processFn.Invoke(musics);
        }
    }
}
