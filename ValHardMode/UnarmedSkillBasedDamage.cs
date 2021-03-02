using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Humanoid), "GetCurrentWeapon")]
    public static class UnarmedSkillBasedDamage
    {
        private static ItemDrop.ItemData Postfix(ItemDrop.ItemData __weapon, ref Character __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (__weapon != null && __weapon.m_shared.m_name == "Unarmed")
                {
                    __weapon.m_shared.m_damages.m_blunt = __instance.GetSkillFactor(Skills.SkillType.Unarmed) * 10;
                }
            }

            return __weapon;
        }
    }
}
