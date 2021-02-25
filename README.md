# ValHardMode - Hard Mode mod for Valheim
ValHardMode is a mod that is intended to increase the difficulty of Valheim while also including some low-impact QoL changes.

It is meant to run on a dedicated server and requires all players connecting to that server to install the mod as well.

## Current Features

### Quality of Life
* Auto-enables position sharing
* Increases max stack size of stackable items to 999
* Increases max capacity of Smelter-like objects by 5x
* Fireplace-type objects don't consume fuel
* Allow usage of items while swimming
* Ability to delete items by picking them up and hitting DEL key (this is not reversible and there is no confirmation!)

### Difficulty Increases
* Increases normal enemy health by 2x
* Increases all boss health by 1.5x
* Increased Eikthyr movement speeds
* Double the chance for enemies to be a higher level
* Prevents most non-equippable/consumable items from being teleported
* Increased damage taken by ships from large waves

### Server Handshaking
* Mod will only load connecting to a dedicated server with the same version installed
* Servers running this mod will only allow clients to connect if they also have the same version of the mod installed


## Installation

1. Backup your characters and worlds! Copy `C:\Users\<username>\AppData\LocalLow\IronGate\Valheim` somewhere just in case
2. Install [BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/) on client and/or server
3. Download latest release and copy `ValHardMode.dll` to `<Steam Location>\steamapps\common\Valheim\BepInEx\plugins`
4. Start game and/or server and enjoy!

## Known Issues

* When removing the mod, or loading a character that played on a modded server in a non-modded server, item stacks or ore/fuel in Smelter-type objects over the normal max amount will be lost