namespace RockyPanelBackend
{
    public class Constants
    {
        public static string Version { get; set; } = "Canary";
        public static string PanelName { get; set; } = "Rocky";
        public static string Theme { get; set; } = "dashtreme";
        public static string Lang { get; set; } = "de";
        public static string DatabaseName { get; set; }
        public static string DatabaseUsername { get; set; }
        public static string DatabasePassword { get; set; }
        public static string DatabaseHost { get; set; }
        public static string DatabasePort { get; set; }
        public static string DatabaseConnectionString
        {
            get
            {
                return
                $"server={DatabaseHost};" +
                $"database={DatabaseName};" +
                $"uid={DatabaseUsername};" +
                $"port={DatabasePort};" +
                $"pwd={DatabasePassword}";
            }
        }

        public static void ReadFromFile(string fileName)
        {
            PropertiesConfigReader pcr = new PropertiesConfigReader(fileName);

            PanelName = pcr.Values["panel.name"];
            Theme = pcr.Values["panel.theme"];
            Lang = pcr.Values["panel.lang"];
            DatabaseName = pcr.Values["database.name"];
            DatabaseUsername = pcr.Values["database.username"];
            DatabasePassword = pcr.Values["database.password"];
            DatabaseHost = pcr.Values["database.host"];
            DatabasePort = pcr.Values["database.port"];
        }
    }
}
