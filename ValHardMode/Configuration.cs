using BepInEx.Configuration;

namespace ValHardMode
{
    public class Configuration
    {
        public static Configuration Current { get; set; }

        public string Version = "0.0.2";
        public bool IsEnabled { get; set; }
        public ConfigEntry<string> DeleteHotkey { get; set; }
    }
}
