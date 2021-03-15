using HarmonyLib;
using UnityEngine;
using System.Collections.Generic;

namespace ValHardMode
{
    [HarmonyPatch(typeof(SE_Rested))]
    public static class ComfortRange
    {
        [HarmonyPrefix]
        [HarmonyPatch("GetNearbyPieces")]
        private static bool GetNearbyPiecesReplacement(Vector3 point, ref List<Piece> __result, ref List<Piece> ___m_tempPieces)
        {
            if (Configuration.Current.IsEnabled)
            {
                ___m_tempPieces.Clear();
                Piece.GetAllPiecesInRadius(point, Configuration.Current.ComfortRange, ___m_tempPieces);
                __result = ___m_tempPieces;
                return false;
            }

            return true;
        }
    }
}