using System.Collections.Generic;

namespace ValHardMode
{
    public class Configuration
    {
        public static Configuration Current { get; set; }

        public string Version = "0.0.15";
        public bool IsEnabled { get; set; }
        public string WorldSuffixEnabler = "VHM";

        public int DataRateOverride = 250;

        // Building
        public float CraftingStationBuildRangeFactor = 2;
        public float MaxStationExtensionDistance = 10;
        public float TreeGrowSpeedFactor = 3;

        // Player
        public float UnarmedBaseDamage = 50;

        // Ship
        public float KarveWeightMax = 1000;
        public float LongshipWeightMax = 4000;

        public float ShipWaterImpactDamageFactor = 2.5f;
        public float ShipWaterImpactIntervalFactor = .5f;
        public float ShipUpsideDownDamageFactor = 2.5f;

        public int KarveCargoSlotsWidth = 3;

        // Random Events
        public int RandomEventMaxSpawnedFactor = 2;
        public float RandomEventChance = 25;
        public float RandomEventIntervalMin = 30;
        public List<string> RandomEventsToDisable = new List<string>()
        {
            "surtlings"
        };
        public List<string> RandomEventsToRemoveReqs = new List<string>()
        {
            "skeletons"
        };
        public List<string> RandomEventsToRemoveLimits = new List<string>()
        {
            "skeletons"
        };

        // All Enemies
        // Spawning
        public int EnemySpawnAmountFactor = 2;
        public float EnemyLevelUpChanceFactor = 4;
        public float EnemyLevelSizeIncreaseFactor = .2f;

        // AI
        public bool RemoveEnemyFireAvoid = true;
        public float EnemyAttackMinIntervalFactor = .5f;

        // Attack
        public float EnemyAttackDamageFactor = 1.75f;
        public float EnemyAttackIntervalFactor = .5f;
        public float EnemyAttackSpeedFactor = .5f;

        public float NonBossEnemyMaxHealthFactor = 2.3f;

        // Unique Enemies
        // Troll
        public float TrollMovementSpeedFactor = 2f;

        // Bosses
        public float BossMaxHealthFactor = 1.5f;

        public float EikthyrMovementSpeedFactor = 3;
        public float EikthyrAttackSpeedFactor = 2;
        public float EikthyrAttackMinIntervalFactor = .3f;

        public float ElderWalkSpeed = 10;
        public float ElderRunSpeed = 12;
        public float ElderTurnSpeed = 200;
        public float ElderRunTurnSpeed = 300;

        // Enemy drops
        public int MaxLevelEnemyDrops = 2;

        public EnemyDropOverride[] EnemyDropOverrides = new EnemyDropOverride[]
        {
            new EnemyDropOverride()
            {
                Name = "$enemy_draugrelite",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_draugrelite",
                        Chance = .25f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_greydwarf",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_greydwarf",
                        Chance = .1f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_greydwarfbrute",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_greydwarfbrute",
                        Chance = .25f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_wraith",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_wraith",
                        Chance = .25f
                    }
                }
            },
            new EnemyDropOverride()
            {
                Name = "$enemy_drake",
                Drops = new DropOverride[]
                {
                    new DropOverride()
                    {
                        ItemName = "$item_trophy_hatchling",
                        Chance = .25f
                    }
                }
            }
        };

        // Recipes
        public bool SwordFireEnabled = true;
        public int SwordFireMinStationLevel = 5;
        public RecipeOverride[] RecipeOverrides = new RecipeOverride[]
        {
// Arrows
            new RecipeOverride()
            {
                Name = "Recipe_ArrowWood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowFlint",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3,
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowFire",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flint",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3,
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 10,
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowFrost",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 5
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowPoison",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_obsidian",
                        Amount = 5
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowObsidian",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArrowNeedle",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_feathers",
                        Amount = 3
                    }
                }
            },
// Weapons
// Clubs
            new RecipeOverride()
            {
                Name = "Recipe_Club",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SledgeStagbreaker",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 15
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MaceBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 5,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_greydwarfbrute",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MaceIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugrelite",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
// Axes
            new RecipeOverride()
            {
                Name = "Recipe_AxeStone",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AxeFlint",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_boar",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AxeBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 4
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 2,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_greydwarf",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_Battleaxe",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_elderbark",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_wraith",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AxeIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 8,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 5,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
// Pickaxes
            new RecipeOverride()
            {
                Name = "Recipe_PickaxeBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 5,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_greydwarf",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_PickaxeIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 5,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 10,
                        AmountPerLevel = 3,
                        Recover = true
                    }
                }
            },
// Swords
            new RecipeOverride()
            {
                Name = "Recipe_SwordBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 5,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_greydwarfbrute",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SwordIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugrelite",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_SwordFire",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_surtlingcore",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 30,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_flametal",
                        Amount = 40,
                        AmountPerLevel = 12
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 15,
                        AmountPerLevel = 4,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_ymirremains",
                        Amount = 10,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
// Knives
            new RecipeOverride()
            {
                Name = "Recipe_KnifeFlint",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 4,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        AmountPerLevel = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_KnifeCopper",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 6,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 2
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_KnifeChitin",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 6,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        AmountPerLevel = 1
                    }
                }
            },
// Atgeirs
            new RecipeOverride()
            {
                Name = "Recipe_AtgeirBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Amount = 5,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_greydwarfbrute",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_AtgeirIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugrelite",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
// Spears
            new RecipeOverride()
            {
                Name = "Recipe_SpearBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 4
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 2,
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
// Bows
            new RecipeOverride()
            {
                Name = "Recipe_Bow",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                        AmountPerLevel = 6,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_boar",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_BowFineWood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_deer",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_BowHuntsman",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 25,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
// Shields
            new RecipeOverride()
            {
                Name = "Recipe_ShieldWood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_boar",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldWoodTower",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 25,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_neck",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldBronzeBuckler",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 5,
                        AmountPerLevel = 2
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_greydwarfshaman",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldBanded",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 20,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugr",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ShieldIronTower",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 25
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugr",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
// Armor
            new RecipeOverride()
            {
                Name = "Recipe_HelmetLeather",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_boar",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorLeatherChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_deer",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorLeatherLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_deer",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 1
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CapeDeerHide",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_deer",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 2,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorTrollLeatherChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 10,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_troll",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorTrollLeatherLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 10,
                        AmountPerLevel = 3
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_troll",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_CapeTrollHide",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_troll",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 10,
                        AmountPerLevel = 4
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_HelmetBronze",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_skeleton",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorBronzeChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_skeleton",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorBronzeLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        AmountPerLevel = 1
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_skeleton",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_greydwarfeye",
                        Amount = 3,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_HelmetIron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 35,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 3,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugr",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorIronChest",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 4,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugr",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_ArmorIronLegs",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 40,
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trollhide",
                        Amount = 4,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bronze",
                        Amount = 10,
                        AmountPerLevel = 2,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_draugr",
                        Amount = 1,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
 // Consumables
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseHealthMinor",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseHealthMedium",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseStaminaMinor",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseStaminaMedium",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_MeadBaseTasty",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new RecipeOverride()
            {
                Name = "Recipe_QueensJam",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            }
        };

        // Pieces
        public PieceOverride[] PieceOverrides = new PieceOverride[]
        {
            new PieceOverride()
            {
                Name = "$piece_firepit",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_groundtorchwood",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 10
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_workbench",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 3,
                        AmountPerLevel = 5,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_cookingstation",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 2,
                        AmountPerLevel = 2,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$ship_raft",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 30
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_cauldron",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_tin",
                        Amount = 15,

                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_forge",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 25
                    },
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_copper",
                        Amount = 10
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_smelter",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 40
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 10,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_charcoalkiln",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 50
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_blastfurnace",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 50
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 30
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_stonecutter",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_stone",
                        Amount = 15
                    },
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_iron",
                        Amount = 5
                    },
                    new OverrideReq()
                    {
                        Name = "$item_roundlog",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_artisanstation",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 20
                    },
                    new OverrideReq()
                    {
                        Name = "$item_silver",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_windmill",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_wood",
                        Amount = 50
                    },
                    new OverrideReq()
                    {
                        Name = "$item_deerhide",
                        Amount = 10,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
            new PieceOverride()
            {
                Name = "$piece_spinningwheel",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_finewood",
                        Amount = 30
                    },
                    new OverrideReq()
                    {
                        Name = "$item_chitin",
                        Amount = 5,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            }
        };


        public class PieceOverride
        {
            public string Name;
            public OverrideReq[] Requirements;
        }

        public class RecipeOverride
        {
            public string Name;
            public OverrideReq[] Requirements;
        }

        public class OverrideReq
        {
            public string Name;
            private int m_amount;
            public bool AmountIsSet = false;
            public int Amount
            {
                get
                {
                    return m_amount;
                }
                set
                {
                    m_amount = value;
                    AmountIsSet = true;
                }
            }

            private int m_amountPerLevel;
            public bool AmountPerLevelIsSet = false;
            public int AmountPerLevel
            {
                get
                {
                    return m_amountPerLevel;
                }
                set
                {
                    m_amountPerLevel = value;
                    AmountPerLevelIsSet = true;
                }
            }
            private bool m_recover;
            public bool RecoverIsSet = false;
            public bool Recover
            {
                get
                {
                    return m_recover;
                }
                set
                {
                    m_recover = value;
                    RecoverIsSet = true;
                }
            }
            public bool Remove = false;
        }

        public class EnemyDropOverride
        {
            public string Name;
            public DropOverride[] Drops;
        }

        public class DropOverride
        {
            public string ItemName;
            private int m_amountMin;
            public bool AmountMinIsSet = false;
            public int AmountMin
            {
                get
                {
                    return m_amountMin;
                }
                set
                {
                    m_amountMin = value;
                    AmountMinIsSet = true;
                }
            }
            private int m_amountMax;
            public bool AmountMaxIsSet = false;
            public int AmountMax
            {
                get
                {
                    return m_amountMax;
                }
                set
                {
                    m_amountMax = value;
                    AmountMaxIsSet = true;
                }
            }
            private float m_chance;
            public bool ChanceIsSet = false;
            public float Chance
            {
                get
                {
                    return m_chance;
                }
                set
                {
                    m_chance = value;
                    ChanceIsSet = true;
                }
            }
            private bool m_onePerPlayer;
            public bool OnePerPlayerIsSet = false;
            public bool OnePerPlayer
            {
                get
                {
                    return m_onePerPlayer;
                }
                set
                {
                    m_onePerPlayer = value;
                    OnePerPlayerIsSet = true;
                }
            }
            private bool m_levelMultiplier;
            public bool LevelMultiplierIsSet = false;
            public bool LevelMultiplier
            {
                get
                {
                    return m_levelMultiplier;
                }
                set
                {
                    m_levelMultiplier = value;
                    LevelMultiplierIsSet = true;
                }
            }
            public bool Remove = false;
        }
    }
}
