using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SharpPhone
{
    public class SharpPhoneFileStorage
    {
        private string dataPath;

        // week 5: pad naar AppData maken
        public SharpPhoneFileStorage()
        {
            string appFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "SharpPhone"
            );

            Directory.CreateDirectory(appFolder); // zorgt dat map bestaat

            dataPath = Path.Combine(appFolder, "data.json");
        }

        // week 5: JSON laden
        public SharpPhoneDataStore Load()
        {
            if (!File.Exists(dataPath))
                return new SharpPhoneDataStore();

            string json = File.ReadAllText(dataPath);

            if (string.IsNullOrWhiteSpace(json))
                return new SharpPhoneDataStore();

            return JsonSerializer.Deserialize<SharpPhoneDataStore>(json)
                   ?? new SharpPhoneDataStore();
        }

        // week 5: JSON opslaan
        public void Save(SharpPhoneDataStore data)
        {
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(dataPath, json);
        }
    }
}