# ValHardMode - Hard Mode mod for Valheim
ValHardMode is a mod that is intended to increase the difficulty of Valheim while also including some low-impact QoL changes.

It is meant to run on a dedicated server and requires all players connecting to that server to install the mod as well.

## Current Features

### Quality of Life
* Reduce death skill penalty to only reset progress on current level
* Increases max stack size of stackable items
* Increases max capacity of Smelter-like objects
* Fireplace-type objects don't consume fuel
* Increased build range of crafting stations

### Difficulty Increases

#### Enemies
* Increases all enemy health and attack damage
* Double the chance for enemies to be a higher level
* Limit higher level enemy drops (except tamed)
* Increased overall group spawn numbers
* Increased size of level 2 and 3 enemies
* Removed any fear of fire
* Updates to certain drop rates

#### Bosses
* Increased Eikthyr and Elder movement speed and special attack damage

#### Items
* Prevent most non-equippable/consumable items from being teleported
* Lots of updates to crafting requirements

#### Random Events
* Increased potential frequency and duration
* Enabled Skeleton & Troll events to happen at any time
* Removed Surtling event

#### Ships
* Increased damage taken by ships from large waves
* Ships now have a max weight and will begin to sink if it is exceeded

### Server Handshaking
* Shared features will only load when connecting to a dedicated server with the same version installed
* Servers running this mod will only allow clients to connect if they also have the same version of the mod installed


## Installation

1. Backup your characters and worlds! Copy `C:\Users\<username>\AppData\LocalLow\IronGate\Valheim` somewhere safe just in case
2. Install [BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/) (v5.4.602 or higher) on clients and server
3. Download latest release and extract `ValHardMode.dll` to `...\BepInEx\plugins` folder created from previous step
4. Enjoy!


## Known Issues

* When removing the mod, or loading a character that played on a modded server in a non-modded server, item stacks or ore/fuel in Smelter-type objects over the normal max amount will be lost
