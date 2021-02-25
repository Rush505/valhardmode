using HarmonyLib;
using System;
using System.Collections.Generic;

namespace ValHardMode
{
    [HarmonyPatch(typeof(SpawnArea), "Awake")]
    public static class IncreaseMobLevelChance
    {
        private static void Postfix(ref SpawnArea __instance)
        {
            // Double the chance for higher level mobs
            if (Configuration.Current.IsEnabled)
            {
                __instance.m_levelupChance = __instance.m_levelupChance * 2;
            }
        }
    }
}
