using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ZNet), "Awake")]
    public static class AutoSetSharedPosition
    {
        private static void Postfix(ref ZNet __instance)
        {
            // Set player position visibility to public by default on game start
            __instance.SetPublicReferencePosition(true);
        }
    }
}
