using BepInEx.Configuration;
using System.Collections.Generic;

namespace ValHardMode
{
    public class Configuration
    {
        public static Configuration Current { get; set; }

        public string Version = "0.0.10";
        public bool IsEnabled { get; set; }

        public ConfigEntry<string> DeleteHotkey { get; set; }

        public float CraftingStationBuildRangeFactor = 2f;

        // Ship
        public float KarveWeightMax = 1000;
        public float LongshipWeightMax = 4000;

        // Random Events
        public float RandomEventChance = 20f;
        public float RandomEventMinInterval = .5f;
        public List<string> RandomEventsToRemoveReqs = new List<string>()
        {
            "skeletons",
            "foresttrolls"
        };

        public List<string> RandomEventsToRemoveLimits = new List<string>()
        {
            "army_theelder"
        };

        // Enemies
        public float EnemyLevelUpChanceFactor = 4f;
        public int EnemySpawnAmountFactor = 2;

        public int MaxLevelEnemyDrops = 1;
        public bool TamedDropNormalLoot = true;

        public float EnemyLevelSizeIncreaseFactor = .3f;
        public float EnemyLevelSizeIncreaseFactorIndoors = .1f;

        public float NonBossEnemyMaxHealthFactor = 2.5f;
        public float BossMaxHealthFactor = 1.5f;

        public float TrollMovementSpeedFactor = 1.5f;

        public float EikthyrMovementSpeedFactor = 4f;
        public float EikthyrAttackSpeedFactor = 2f;

        public float ElderWalkSpeed = 10f;
        public float ElderRunSpeed = 12f;
        public float ElderTurnSpeed = 200f;
        public float ElderRunTurnSpeed = 300f;

        public float EnemyAttackDamageFactor = 2f;
        public float EnemyAttackIntervalFactor = .5f;
        public float EnemyAttackSpeedFactor = .1f;
        public float EnemyAttackMinInterval = 1;

        // Recipes
        public RecipeOverride[] RecipeOverrides = new RecipeOverride[]
        {
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
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    }
                }
            },
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
                        Amount = 2,
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
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
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
                        Name = "$item_trophy_neck",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_trophy_boar",
                        Amount = 2,
                        AmountPerLevel = 0,
                        Recover = true
                    }
                }
            },
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
                        AmountPerLevel = 1,
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
                        AmountPerLevel = 1,
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
                        Amount = 2,
                        AmountPerLevel = 1,
                        Recover = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_bonefragments",
                        Amount = 15,
                        AmountPerLevel = 8
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
                        Amount = 5,
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
                Name = "Recipe_MeadBaseHealthMinor",
                Requirements = new OverrideReq[]
                {
                    new OverrideReq()
                    {
                        Name = "$item_dandelion",
                        Amount = 5
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
                        Amount = 10
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
            },
            new RecipeOverride()
            {
                Name = "Recipe_SwordFire",
                Requirements = new OverrideReq[]
                {
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
                        AmountPerLevel = 10
                    },
                    new OverrideReq()
                    {
                        Name = "$item_surtlingcore",
                        Amount = 15,
                        AmountPerLevel = 8
                    },
                    new OverrideReq()
                    {
                        Name = "$item_leatherscraps",
                        Remove = true
                    },
                    new OverrideReq()
                    {
                        Name = "$item_resin",
                        Amount = 100,
                        AmountPerLevel = 20,
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
                        Amount = 10,
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
                        Amount = 10,
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
    }
}
