# ValHardMode - Hard Mode mod for Valheim
ValHardMode is a mod that is intended to increase the difficulty of Valheim while also including some low-impact QoL changes.

It is meant to run on a dedicated server and requires all players connecting to that server to install the mod as well.

## Current Features

### Quality of Life
#### Always On
* Allow usage of items while swimming
* Ability to delete items by picking them up and hitting DEL key (this is not reversible and there is no confirmation!)
* Always enable DLC content

#### Server Activated
* Increases max stack size of stackable items
* Increases max capacity of Smelter-like objects
* Fireplace-type objects don't consume fuel
* Increased crafting station use range

### Difficulty Increases
* Increases normal enemy health
* Double the chance for enemies to be a higher level
* Increased Eikthyr movement speed and special attack damage
* Prevents most non-equippable/consumable items from being teleported
* Increased damage taken by ships from large waves
* Increased difficulty and frequency of random events

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
