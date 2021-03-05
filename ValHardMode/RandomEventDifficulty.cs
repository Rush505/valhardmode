using HarmonyLib;

namespace ValHardMode
{
    [HarmonyPatch(typeof(RandEventSystem), "Awake")]
    public static class RandomEventDifficulty
    {
        private static void Postfix(ref RandEventSystem __instance)
        {
            if (Configuration.Current.IsEnabled)
            {
                foreach (RandomEvent evnt in __instance.m_events)
                {
                    if (Configuration.Current.RandomEventsToDisable.Contains(evnt.m_name))
                    {
                        evnt.m_enabled = false;
                    }

                    if (Configuration.Current.RandomEventsToRemoveReqs.Contains(evnt.m_name))
                    {
                        // Clear any boss kill requirements
                        evnt.m_requiredGlobalKeys.Clear();
                    }

                    if (Configuration.Current.RandomEventsToRemoveLimits.Contains(evnt.m_name))
                    {
                        // Clear any no boss kill requirements
                        evnt.m_notRequiredGlobalKeys.Clear();
                    }

                    // Change the max amount of possible spawns
                    foreach (SpawnSystem.SpawnData spawn in evnt.m_spawn)
                    {
                        spawn.m_maxSpawned = spawn.m_maxSpawned * Configuration.Current.RandomEventMaxSpawnedFactor;
                    }
                }

                // Increase chance of happening
                __instance.m_eventChance = Configuration.Current.RandomEventChance;

                // Decrease minimum time to happen
                __instance.m_eventIntervalMin = Configuration.Current.RandomEventIntervalMin;
            }
        }
    }
}
