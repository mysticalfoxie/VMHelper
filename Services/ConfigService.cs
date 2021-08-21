using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using AudioProcessHelper.Models;

namespace AudioProcessHelper.Services
{
    class ConfigService
    {
        private const string FILENAME = "lastSession.json";
        private static FileInfo ConfigFile => new(Path.Combine(FILENAME));

        public static void Save(LastSession session)
        {
            var json = JsonConvert.SerializeObject(session);
            File.WriteAllText(ConfigFile.FullName, json);
        }

        public static LastSession Load()
        {
            if (!ConfigFile.Exists) return null;

            var json = File.ReadAllText(ConfigFile.FullName);
            return JsonConvert.DeserializeObject<LastSession>(json);
        }
    }

    static class SessionConfigExtensions
    {
        public static LastSession ReadSession(this CheckedListBox listbox)
        {
            var processes = new List<ProcessEntry>();
            for (int i = 0; i < listbox.Items.Count; i++)
                processes.Add(new()
                {
                    Name = listbox.Items[i] as string,
                    Checked = listbox.GetItemChecked(i)
                });

            return new()
            {
                Processes = processes.ToArray()
            };
        }
    }
}
