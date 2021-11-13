using System;
using System.Collections.Generic;
using System.Linq;

namespace RockyPanelBackend.Session
{
    public class SessionStorageProvider
    {
        private static Dictionary<string, KeyValueStorage> Data { get; set; } = new Dictionary<string, KeyValueStorage>();
    
        public static KeyValueStorage GetOrCreate(string key)
        {
            if (!Data.ContainsKey(key))
                Data.Add(key, new KeyValueStorage());

            return Data[key];
        }
        public static string GenerateKey() // Generates token with timestamp
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());

            return token;
        }

        public static bool TokenValid(string token)
        {
            byte[] data = Convert.FromBase64String(token);
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            if (when < DateTime.UtcNow.AddHours(-24))
            {
                return false; // Too old
            }
            else
            {
                return Data.ContainsKey(token);
            }
        }
    }
}
