using HarmonyLib;
using UnityEngine;
using BepInEx;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ZNet), "Awake")]
    public static class AutoSetSharedPosition
    {
        private static void Postfix(ref ZNet __instance)
        {
            // Set player position visibility to public by default on server join
            __instance.SetPublicReferencePosition(true);
        }
    }
}
