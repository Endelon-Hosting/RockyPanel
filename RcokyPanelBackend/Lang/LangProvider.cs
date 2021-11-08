namespace RockyPanelBackend.Lang
{
    public class LangProvider
    {
        private static PropertiesConfigReader ConfigReader { get; set; }

        public static void Load()
        {
            ConfigReader = new PropertiesConfigReader($"Langs/{Constants.Lang}.lang");
        }

        public static string Get(string key)
        {
            if (!ConfigReader.Values.ContainsKey(key))
                return $"Key {key} not found";

            return ConfigReader.Values[key];
        }
    }
}
