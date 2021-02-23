using HarmonyLib;
using BepInEx;
using UnityEngine;
using System;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ItemDrop), "Awake")]
    public static class IncreasedStacks
    {
        private static void Prefix(ref ItemDrop __instance)
        {
            if (__instance.m_itemData.m_shared.m_maxStackSize > 1)
            {
                    __instance.m_itemData.m_shared.m_maxStackSize = 999;
            }
        }

        private static void Postfix(ref ItemDrop __instance)
        {
            if (__instance.m_itemData.m_shared.m_itemType == ItemDrop.ItemData.ItemType.Material
                || __instance.m_itemData.m_shared.m_itemType == ItemDrop.ItemData.ItemType.Misc
                || __instance.m_itemData.m_shared.m_itemType == ItemDrop.ItemData.ItemType.Trophie)
            {
                __instance.m_itemData.m_shared.m_teleportable = false;
            }
        }
    }
}
