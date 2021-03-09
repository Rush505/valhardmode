using HarmonyLib;
using System.Collections.Generic;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ZNetScene), "Awake")]
    public static class AddBoarRandomEvent
    {
        private static void Postfix()
        {
            ZLog.Log("ValHardMode - Adding Boars random event");

            if (Configuration.Current.IsEnabled)
            {
                var boarPrefab = ZNetScene.instance.GetPrefab("Boar");

                if (boarPrefab == null)
                {
                    ZLog.LogWarning("ValHardMode - Failed to load Boar prefab for event");
                    return;
                }

                if (RandEventSystem.instance == null || RandEventSystem.instance.m_events == null)
                {
                    ZLog.LogWarning("ValHardMode - RandEventSystem is null");
                    return;
                }

                RandEventSystem.instance.m_events.Add(new RandomEvent()
                {
                    m_name = "vhm-boars",
                    m_enabled = true,
                    m_random = true,
                    m_duration = 120,
                    m_nearBaseOnly = true,
                    m_pauseIfNoPlayerInArea = true,
                    m_biome = Heightmap.Biome.Meadows | Heightmap.Biome.BlackForest | Heightmap.Biome.Swamp | Heightmap.Biome.Mountain | Heightmap.Biome.Plains,
                    m_requiredGlobalKeys = new List<string>(),
                    m_notRequiredGlobalKeys = new List<string>(),
                    m_startMessage = "Boars!",
                    m_endMessage = "The boars are getting sleepy...",
                    m_forceMusic = "CombatEventL1",
                    m_forceEnvironment = "",
                    m_spawn = new List<SpawnSystem.SpawnData>()
                    {
                        new SpawnSystem.SpawnData()
                        {
                            m_name = "boarsevent",
                            m_enabled = true,
                            m_biome = Heightmap.Biome.Meadows | Heightmap.Biome.BlackForest | Heightmap.Biome.Swamp | Heightmap.Biome.Mountain | Heightmap.Biome.Plains,
                            m_biomeArea = Heightmap.BiomeArea.Everything,
                            m_maxSpawned = 20,
                            m_spawnInterval = 10,
                            m_spawnChance = 100,
                            m_spawnDistance = 10,
                            m_spawnRadiusMax = 0,
                            m_spawnRadiusMin = 0,
                            m_requiredGlobalKey = "",
                            m_requiredEnvironments = new List<string>(),
                            m_groupSizeMin = 3,
                            m_groupSizeMax = 10,
                            m_groupRadius = 5,
                            m_spawnAtNight = true,
                            m_spawnAtDay = true,
                            m_minAltitude = 0,
                            m_maxAltitude = 1000,
                            m_minTilt = 0,
                            m_maxTilt = 35,
                            m_inForest = true,
                            m_outsideForest = true,
                            m_minOceanDepth = 0,
                            m_maxOceanDepth = 0,
                            m_huntPlayer = true,
                            m_groundOffset = 0,
                            m_maxLevel = 3,
                            m_minLevel = 1,
                            m_levelUpMinCenterDistance = 0,
                            m_foldout = false,
                            m_prefab = boarPrefab
                        }
                    }
                });
            }
        }
    }
}
