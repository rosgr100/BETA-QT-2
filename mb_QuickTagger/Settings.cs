using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using static MusicBeePlugin.Plugin;
using SerializeDictionary;

namespace MusicBeePlugin
{
    public class SettingsModel
    {
        public SettingsModel()
        {
            Tags = new SerializableDictionary<MetaDataType, string>();
            PriorityWords = new List<string>(); // Initialize the PriorityWords list
        }

        public SerializableDictionary<MetaDataType, string> Tags { get; set; }
        public List<string> PriorityWords { get; set; }

        public void WriteXml(XmlWriter writer)
        {
            // Serialize the dictionary items
            foreach (var keyValuePair in Tags)
            {
                writer.WriteStartElement("Tag");
                writer.WriteElementString("Key", keyValuePair.Key.ToString());
                writer.WriteElementString("Value", keyValuePair.Value);
                writer.WriteEndElement();
            }

            // Serialize the PriorityWords list
            writer.WriteStartElement("PriorityWords");
            foreach (var word in PriorityWords)
            {
                writer.WriteElementString("PriorityWord", word);
            }
            writer.WriteEndElement();
        }

        public void ReadXml(XmlReader reader)
        {
            // Your existing ReadXml method code goes here
        }
    }

    public static class PluginSettings
    {
        private const string CONFIG_FILE_PATH_RAW = "mb_QuickTagger.config";

        public static SettingsModel Settings = new SettingsModel();

        public static void SaveSettings()
        {
            Write<SettingsModel>(ConfigPath);
        }

        public static void LoadSettings()
        {
            Settings = Read<SettingsModel>(ConfigPath) ?? new SettingsModel();
        }

        public static void PurgeEverything()
        {
            try
            {
                File.Delete(ConfigPath);
            }
            catch { }
        }

        private static void Write<T>(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                xmls.Serialize(sw, Settings);
            }
        }

        private static T Read<T>(string filename)
        {
            if (!File.Exists(filename))
            {
                Write<T>(filename);
            }
            using (StreamReader sw = new StreamReader(filename))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                T settings = (T)xmls.Deserialize(sw);

                // Check if the deserialized object is SettingsModel
                if (settings is SettingsModel settingsModel)
                {
                    // Load the PriorityWords list from the deserialized object
                    PluginSettings.Settings.PriorityWords = settingsModel.PriorityWords;
                }

                return settings;
            }
        }

        private static string ConfigPath
        {
            get { return Path.Combine(Api.Setting_GetPersistentStoragePath(), CONFIG_FILE_PATH_RAW); }
        }
    }
}