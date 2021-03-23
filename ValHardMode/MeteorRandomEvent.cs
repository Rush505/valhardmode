//using HarmonyLib;
//using System.Collections.Generic;
//using UnityEngine;

//namespace ValHardMode
//{
//    [HarmonyPatch]
//    public static class MeteorRandomEvent
//    {
//        private static float m_timeSinceLastMeteor = 0;
//        private static float m_meteorMinTimeMinutes = .25f;
//        private static float m_meteorChance = 100;

//        [HarmonyPostfix]
//        [HarmonyPatch(typeof(RandEventSystem), "FixedUpdate")]
//        private static void PostFixedUpdate()
//        {
//            // Only run on server
//            if (!ZNet.instance.IsServer())
//                return;

//            float fixedDeltaTime = Time.fixedDeltaTime;
//            m_timeSinceLastMeteor += fixedDeltaTime;

//            if (m_timeSinceLastMeteor > m_meteorMinTimeMinutes * 60.0)
//            {
//                ZLog.Log("ValHardMode - Past minimum time for next meteor");
//                m_timeSinceLastMeteor = 0.0f;

//                if (UnityEngine.Random.Range(0.0f, 100f) <= m_meteorChance)
//                {
//                    ZLog.Log("ValHardMode - Successful meteor roll");

//                    List<ZDO> allCharacterZdos = ZNet.instance.GetAllCharacterZDOS();
//                    List<Vector3> characterPositions = new List<Vector3>();

//                    foreach (ZDO character in allCharacterZdos)
//                    {
//                        if (character.GetPosition().y <= 3000.0)
//                            characterPositions.Add(character.GetPosition());
//                    }

//                    if (characterPositions.Count > 0)
//                    {
//                        var targetPos = characterPositions[UnityEngine.Random.Range(0, characterPositions.Count)];

//                        int xSign = Random.Range(0, 2) * 2 - 1;
//                        int zSign = Random.Range(0, 2) * 2 - 1;

//                        var spawnPos = new Vector3(targetPos.x + 55 * xSign, targetPos.y + 150, targetPos.z + 55 * zSign);
//                        var velocity = new Vector3(-25 * xSign, -80, -25 * zSign);

//                        MeteorRandomEvent.SpawnMeteor(spawnPos, velocity);
//                    }
//                    else
//                    {
//                        ZLog.Log("ValHardMode - No available characters for meteor strike");
//                    }
//                }
//            }
//        }

//        public static void SpawnMeteor(Vector3 spawnPoint, Vector3 velocity)
//        {
//            var meteorPrefab = ZNetScene.instance.GetPrefab("projectile_meteor");
//            if (meteorPrefab == null)
//            {
//                ZLog.LogWarning("ValHardMode - Unable to get meteor prefab");
//                return;
//            }

//            // Spawn meteor
//            ZLog.Log("ValHardMode - Spawning Meteor at " + spawnPoint.ToString());
//            GameObject goProjectile = UnityEngine.Object.Instantiate<GameObject>(meteorPrefab, spawnPoint, Quaternion.identity);

//            HitData hitData = new HitData()
//            {
//                m_pushForce = 1000f,
//                m_damage = new HitData.DamageTypes()
//                {
//                    m_blunt = 1000,
//                    m_pickaxe = 1000,
//                    m_chop = 1000,
//                    m_fire = 500
//                }
//            };

//            Projectile proj = goProjectile.GetComponent<Projectile>();
//            proj.name = "vhm-meteor";
//            proj.Setup(null, velocity, 100f, hitData, null);
//        }

//        [HarmonyPostfix]
//        [HarmonyPatch(typeof(Console), "InputText")]
//        private static void ConsoleSpawnMeteor(ref Console __instance)
//        {
//            var inputTxt = __instance.m_input.text;

//            if (__instance.IsCheatsEnabled() && inputTxt.StartsWith("meteor "))
//            {
//                string[] txtArr = inputTxt.Split(' ');

//                int spawnX = 0;
//                int spawnY = 0;
//                int spawnZ = 0;
//                int velocityX = 0;
//                int velocityY = 0;
//                int velocityZ = 0;

//                int.TryParse(txtArr[1], out spawnX);
//                int.TryParse(txtArr[2], out spawnY);
//                int.TryParse(txtArr[3], out spawnZ);
//                int.TryParse(txtArr[4], out velocityX);
//                int.TryParse(txtArr[5], out velocityY);
//                int.TryParse(txtArr[6], out velocityZ);

//                var playerPos = Player.m_localPlayer.transform.position;
//                var spawnPoint = new Vector3(playerPos.x + spawnX, playerPos.y + spawnY, playerPos.z + spawnZ);
//                var velocity = new Vector3(velocityX, velocityY, velocityZ);

//                MeteorRandomEvent.SpawnMeteor(spawnPoint, velocity);
//            }
//        }
//    }

//    [HarmonyPatch(typeof(Projectile))]
//    public static class SpawnMineOnMeteorHit
//    {
//        [HarmonyPrefix]
//        [HarmonyPatch("OnHit")]
//        private static void SpawnOnHitPrefix(ref Projectile __instance, ref bool ___m_didHit, Collider collider, Vector3 hitPoint, bool water)
//        {
//            if (ZNet.instance.IsServer() && __instance.name == "vhm-meteor" && !water)
//            {
//                GameObject hitObj = collider ? Projectile.FindHitObject(collider) : null;

//                if (!Location.IsInsideNoBuildLocation(hitPoint) 
//                    && !___m_didHit
//                    && hitObj.GetComponent<Heightmap>() != null)
//                {
//                    //ItemDrop weapon = ObjectDBWrapper.GetItem("$item_pickaxe_iron");
//                    //if (weapon != null)
//                    //{
//                    //    GameObject spawnOnHitPrefab = weapon.m_itemData.m_shared.m_spawnOnHitTerrain;
//                    //    if (spawnOnHitPrefab != null)
//                    //    {
//                    //        ZLog.Log("ValHardMode - Spawning terrain modifier");
//                    //        TerrainModifier.SetTriggerOnPlaced(true);
//                    //        GameObject go = UnityEngine.Object.Instantiate<GameObject>(spawnOnHitPrefab, hitPoint, Quaternion.identity);
//                    //        TerrainModifier.SetTriggerOnPlaced(false);
//                    //        go.GetComponent<IProjectile>()?.Setup(___m_owner, Vector3.zero, 0f, null, weapon.m_itemData);
//                    //    }
//                    //    else
//                    //    {
//                    //        ZLog.LogWarning("ValHardMode - No spawn on hit prefab found");
//                    //    }
//                    //}
//                    //else
//                    //{
//                    //    ZLog.LogWarning("ValHardMode - Error loading pickaxe prefab for terrain mod");
//                    //}

//                    var minePrefab = ZNetScene.instance.GetPrefab("MineRock_Meteorite");
//                    if (minePrefab == null)
//                    {
//                        ZLog.LogWarning("ValHardMode - Unable to get meteorite mine rock prefab");
//                        return;
//                    }

//                    ZLog.Log("ValHardMode - Spawning meteorite mine");
//                    var spawnPoint = new Vector3(hitPoint.x, hitPoint.y - .5f, hitPoint.z);
//                    UnityEngine.Object.Instantiate<GameObject>(minePrefab, spawnPoint, Quaternion.identity);
//                }
//            }
//        }
//    }
//}