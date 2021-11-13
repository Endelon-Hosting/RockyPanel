using System.Collections.Generic;

using Newtonsoft.Json;

namespace RockyPanelBackend.Session
{
    public class KeyValueStorage
    {
        public Dictionary<string, string> KeyValues { get; set; } = new Dictionary<string, string>();
        public T Get<T>(string key)
        {
            return JsonConvert.DeserializeObject<T>(KeyValues[key]);
        }

        public bool Exists(string key)
        {
            return KeyValues.ContainsKey(key);
        }

        public void Set(string key, object data)
        {
            KeyValues.Add(key, JsonConvert.SerializeObject(data));
        }
    }
}
