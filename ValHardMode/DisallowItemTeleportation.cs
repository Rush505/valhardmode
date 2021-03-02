using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ItemDrop), "Awake")]
    public static class DisallowItemTeleportation
    {
        private static void Postfix(ref ItemDrop __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                // Disallow teleporting of materials, trophies and misc items
                if (__instance.m_itemData.m_shared.m_name != "$item_cryptkey" 
                    && __instance.m_itemData.m_shared.m_name != "$item_wishbone"
                    && (
                        __instance.m_itemData.m_shared.m_itemType == ItemDrop.ItemData.ItemType.Material
                        || __instance.m_itemData.m_shared.m_itemType == ItemDrop.ItemData.ItemType.Misc
                        || __instance.m_itemData.m_shared.m_itemType == ItemDrop.ItemData.ItemType.Trophie
                        )
                    )
                {
                    __instance.m_itemData.m_shared.m_teleportable = false;
                }
            }
        }
    }
}
