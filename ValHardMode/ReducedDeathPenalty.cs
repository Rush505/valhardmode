using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Skills), "Awake")]
    public static class ReducedDeathPenalty
    {
        private static void Postfix(ref Skills __instance)
        {
            __instance.m_DeathLowerFactor = 0;
        }
    }
}
