using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch]
    public static class PieceRestrictionOverrides
    {
        [HarmonyPatch(typeof(Piece), "Awake")]
        [HarmonyPostfix]
        private static void OverridePieceRestrictions(ref Piece __instance)
        {
            if (!Configuration.Current.IsEnabled)
                return;

            if (__instance.m_name == "$piece_bonfire")
            {
                __instance.m_groundOnly = false;
                __instance.m_notOnWood = false;
            }
        }
    }

    [HarmonyPatch(typeof(Player), "GetPiece")]
    public static class BuildingPieceRestrictionOverrides
    {
        private static void Postfix(ref Player __instance, ref Piece __result)
        {
            if (!Configuration.Current.IsEnabled && __result == null)
                return;

            if (__result.m_name == "$piece_bonfire")
            {
                __result.m_groundOnly = false;
                __result.m_notOnWood = false;
            }
        }
    }
}