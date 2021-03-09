using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace ValHardMode
{
    [HarmonyPatch(typeof(ZNetScene), "Awake")]
    public static class AddMeteorRandomEvent
    {
        private static void Postfix()
        {
            if (Configuration.Current.IsEnabled)
            {
                ZLog.Log("ValHardMode - Adding Meteor random event");

                if (RandEventSystem.instance == null || RandEventSystem.instance.m_events == null)
                {
                    ZLog.LogWarning("ValHardMode - RandEventSystem is null");
                    return;
                }

                RandEventSystem.instance.m_events.Add(new RandomEvent()
                {
                    m_name = "vhm-meteorevent",
                    m_enabled = true,
                    m_random = true,
                    m_duration = 10,
                    m_nearBaseOnly = true,
                    m_pauseIfNoPlayerInArea = false,
                    m_biome = Heightmap.Biome.Meadows | Heightmap.Biome.BlackForest | Heightmap.Biome.Swamp | Heightmap.Biome.Mountain | Heightmap.Biome.Plains,
                    m_startMessage = "The sky flashes with light!",
                    m_forceMusic = "",
                    m_forceEnvironment = "Ashrain",
                    m_requiredGlobalKeys = new List<string>()
                    {
                        "defeated_eikthyr"
                    },
                    m_spawn = new List<SpawnSystem.SpawnData>()
                });
            }
        }
    }

    [HarmonyPatch(typeof(RandomEvent))]
    public static class MeteorEvent
    {
        [HarmonyPostfix]
        [HarmonyPatch("OnStart")]
        private static void OnStartPostfix(ref RandomEvent __instance)
        {
            if (__instance.m_name == "vhm-meteorevent")
            {
                MeteorEvent.SpawnMeteor(new Vector3(__instance.m_pos.x + 55, __instance.m_pos.y + 200, __instance.m_pos.z + 55), new Vector3(-30, -100, -30));
            }
        }

        public static void SpawnMeteor(Vector3 spawnPoint, Vector3 velocity)
        {
            var meteorPrefab = ZNetScene.instance.GetPrefab("projectile_meteor");
            if (meteorPrefab == null)
            {
                ZLog.LogWarning("Unable to get meteor prefabs");
                return;
            }

            // Spawn meteor
            ZLog.Log("ValHardMode - Meteor event - Spawning Meteor");
            var meteor = UnityEngine.Object.Instantiate<GameObject>(meteorPrefab, spawnPoint, Quaternion.identity);

            HitData hit = new HitData()
            {
                m_damage = new HitData.DamageTypes()
                {
                    m_blunt = 1000,
                    m_fire = 500
                },
                m_pushForce = 1000
            };

            Projectile projectile = meteor.GetComponent<Projectile>();
            projectile.name = "event-meteor";
            projectile.m_ttl = -1;
            projectile.Setup(null, velocity, 1f, hit, null);
        }
    }

    [HarmonyPatch(typeof(Projectile))]
    public static class SpawnFlametalMineOnMeteorHit
    {
        [HarmonyPostfix]
        [HarmonyPatch("OnHit")]
        private static void SpawnOnHitPostfix(ref Projectile __instance, Collider collider, Vector3 hitPoint, bool water)
        {
            if (__instance.name == "event-meteor" && !water)
            {
                ZLog.Log("ValHardMode - Spawning meteorite mine");
                var minePrefab = ZNetScene.instance.GetPrefab("MineRock_Meteorite");
                UnityEngine.Object.Instantiate<GameObject>(minePrefab, hitPoint, Quaternion.identity);
                SnapToGround.SnappAll();
            }
        }
    }

    [HarmonyPatch(typeof(Console))]
    public static class MeteorConsoleCommand
    {
        [HarmonyPostfix]
        [HarmonyPatch("InputText")]
        private static void ConsoleSpawnMeteor(ref Console __instance)
        {
            var inputTxt = __instance.m_input.text;
 
            if (__instance.IsCheatsEnabled() && inputTxt.StartsWith("meteor"))
            {
                string[] txtArr = inputTxt.Split(' ');

                int spawnX = 0;
                int spawnY = 0;
                int spawnZ = 0;
                int velocityX = 0;
                int velocityY = 0;
                int velocityZ = 0;

                int.TryParse(txtArr[1], out spawnX);
                int.TryParse(txtArr[2], out spawnY);
                int.TryParse(txtArr[3], out spawnZ);
                int.TryParse(txtArr[4], out velocityX);
                int.TryParse(txtArr[5], out velocityY);
                int.TryParse(txtArr[6], out velocityZ);

                var playerPos = Player.m_localPlayer.transform.position;
                var spawnPoint = new Vector3(playerPos.x + spawnX, playerPos.y + spawnY, playerPos.z + spawnZ);
                var velocity = new Vector3(velocityX, velocityY, velocityZ);

                MeteorEvent.SpawnMeteor(spawnPoint, velocity);
            }
        }
    }
}