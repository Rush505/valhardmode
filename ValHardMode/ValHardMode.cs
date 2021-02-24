using System;
using BepInEx;
using HarmonyLib;

namespace ValHardMode
{
    [BepInPlugin("org.remmiz.plugins.valhardmode", "Valheim Hard Mode", "0.0.1.0")]
    public class ValHardMode : BaseUnityPlugin
    {
        public static string version = "0.0.1";

        // Project Repository Info
        public static string Repository = "https://github.com/remmizekim/valhardmode";
        public static string ApiRepository = "https://api.github.com/repos/remmizekim/valhardmode/tags";

        // Awake is called once when both the game and the plug-in are loaded
        void Awake()
        {
            Configuration.Current = new Configuration();
            Configuration.Current.IsEnabled = false;

            Logger.LogInfo("Patching in ValHardMode");
            var harmony = new Harmony("mod.valhardmode");
            harmony.PatchAll();
        }
    }
}