using System;
using System.Collections.Generic;
using System.IO;

namespace RockyPanelBackend
{
    public class PropertiesConfigReader
    {
        public string FileName { get; set; }
        public Dictionary<string, string> Values { get; set; } = new Dictionary<string, string>();
        public PropertiesConfigReader(string fileName)
        {
            FileName = fileName;
            Load();
        }

        public void Save()
        {
            var properties = "";
            var lineEnding = "\n";
            if (OperatingSystem.IsWindows())
                lineEnding = "\r" + lineEnding;
            foreach (var kvp in Values)
            {
                properties += kvp.Key + "=" + kvp.Value;
                properties += lineEnding;
            }
            File.WriteAllText(FileName, properties);
        }

        public void Load()
        {
            var content = File.ReadAllText(FileName);
            var lines = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    if (line.Contains("="))
                    {
                        try
                        {
                            var index = line.IndexOf("=");
                            var key = line.Remove(index);
                            var value = line.Remove(0, index+1);
                            Values[key] = value;
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}