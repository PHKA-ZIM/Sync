using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHStudIPSync
{
    class SyncCommand
    {
        private SyncCommandData SyncCommandData;

        private readonly string ConfigFilePath = @".\scripts\sync\config.json";

        public void SetData(SyncCommandData syncCommandData)
        {
            SyncCommandData = syncCommandData;
        }

        public void Execute()
        {
            CreateConfigFile();
            ExecuteSyncScript();
        }

        private void ExecuteSyncScript()
        {
            var s = new SyncMessageBox();
            s.ShowDialog();
        }

        public bool HasConfig()
        {
            return File.Exists(ConfigFilePath);
        }

        public SyncCommandData GetConfig()
        {
            using (StreamReader file = File.OpenText(ConfigFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                SyncCommandData config = (SyncCommandData)serializer.Deserialize(file, typeof(SyncCommandData));
                return config;
            }
        }

        private void CreateConfigFile()
        {
            WriteConfig();
        }

        public void SaveConfig()
        {
            WriteConfig();
        }

        private void WriteConfig()
        {
            using (StreamWriter file = File.CreateText(ConfigFilePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, SyncCommandData);
            }
        }
    }
}
