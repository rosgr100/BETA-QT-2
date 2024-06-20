
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static MusicBeePlugin.Plugin;

namespace MusicBeePlugin
{
    public struct TagTableModel
    {
        public int code;
        public string value;
    }

    public partial class ConfigurationForm : PluginForm
    {
        Action<TagTableModel[]> _onSaveFn;
        private List<string> priorityWords = new List<string>(); // Class-level variable for priority words

        public ConfigurationForm(Action<TagTableModel[]> onSaveFn)
        {
            _onSaveFn = onSaveFn;
            InitializeComponent();
            InitializeStyle();
            // Add a TextBox control named 'priorityWordsTextBox' in the Designer view
            // Add a Button control named 'savePriorityWordsBtn' in the Designer view and create an event handler 'savePriorityWordsBtn_Click'
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            aboytLbl.Text = $"QuickTagger by SpirosG - v{Info.VersionMajor}.{Info.VersionMinor}.{Info.Revision}";

            tableTagField.Items.AddRange(TagFields);
            tableTagField.DisplayMember = "name";
            tableTagField.ValueMember = "code";
            foreach (var tag in PluginSettings.Settings.Tags)
            {
                tagTable.Rows.Add(new object[] { (int)tag.Key, tag.Value });
            }

            // Load priority words from settings and display them
            priorityWordsTextBox.Text = string.Join(", ", PluginSettings.Settings.PriorityWords);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Ensure priority words are up-to-date
            string[] words = priorityWordsTextBox.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            priorityWords = words.Select(word => word.Trim()).ToList();

            var tags = (from DataGridViewRow row in tagTable.Rows
                        where row.Cells[0].Value != null && row.Cells[1].Value != null
                        select new TagTableModel
                        {
                            code = Convert.ToInt32(row.Cells[0].Value),
                            value = row.Cells[1].Value.ToString(),
                        }).ToList();

            // Sort the list to ensure priority words are at the front
            tags.Sort((x, y) =>
            {
                int indexX = PluginSettings.Settings.PriorityWords.IndexOf(x.value);
                int indexY = PluginSettings.Settings.PriorityWords.IndexOf(y.value);

                if (indexX != -1 && indexY != -1)
                    return indexX.CompareTo(indexY); // Both are priority words
                if (indexX != -1)
                    return -1; // x is a priority word
                if (indexY != -1)
                    return 1; // y is a priority word

                return 0; // Neither are priority words, do not sort alphabetically
            });

            _onSaveFn.Invoke(tags.ToArray());
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableAddBtn_Click(object sender, EventArgs e)
        {
            tagTable.Rows.Add();
        }

        private void tableRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                tagTable.Rows.RemoveAt(tagTable.SelectedRows[0].Index);
            }
            catch { }
        }

        private void savePriorityWordsBtn_Click(object sender, EventArgs e)
        {
            // Save edited priority words back to settings
            string[] words = priorityWordsTextBox.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            priorityWords = words.Select(word => word.Trim()).ToList();

            PluginSettings.Settings.PriorityWords = priorityWords;
            PluginSettings.SaveSettings(); // Save the updated settings to the config file
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Add any additional event handlers here if needed.
    }
}
