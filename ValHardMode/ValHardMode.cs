using System;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace ValHardMode
{
    [BepInPlugin("org.remmiz.plugins.valhardmode", "ValHardMode", "1.0.2.0")]
    public class ValHardMode : BaseUnityPlugin
    {
        void Awake()
        {
            Configuration.Current = new Configuration();
            Configuration.Current.IsEnabled = false;

            string gitRepo = "https://github.com/remmizekim/valhardmode";
            string gitApiRepo = "https://api.github.com/repos/remmizekim/valhardmode/tags";

            Logger.LogInfo("ValHardMode - Patching in");
            var harmony = new Harmony("mod.valhardmode");
            harmony.PatchAll();
        }
    }
}