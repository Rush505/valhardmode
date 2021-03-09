using HarmonyLib;
using System.Collections.Generic;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ItemDrop), "Awake")]
    public static class MaxItemStacks
    {
        private static void Prefix(ref ItemDrop __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Allow all stackable items to stack up to 999
                if (__instance.m_itemData.m_shared.m_maxStackSize > 1)
                {
                    __instance.m_itemData.m_shared.m_maxStackSize = 999;
                }
            }
        }
    }
}
