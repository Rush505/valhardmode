using HarmonyLib;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(Humanoid), "GetCurrentWeapon")]
    public static class UnarmedSkillBasedDamage
    {
        private static ItemDrop.ItemData Postfix(ItemDrop.ItemData __weapon, ref Character __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                if (__instance != null && __weapon != null && __weapon.m_shared.m_name == "Unarmed")
                {
                    float unarmedDmg = __instance.GetSkillFactor(Skills.SkillType.Unarmed) * Configuration.Current.UnarmedBaseDamage + 5;
                    __weapon.m_shared.m_damages.m_blunt = Mathf.Lerp(unarmedDmg * 0.85f, unarmedDmg * 1.15f, UnityEngine.Random.value);
                }
            }

            return __weapon;
        }
    }
}