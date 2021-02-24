# ValHardMode - Hard Mode mod for Valheim

## Current Features

### Quality of Life
* Auto-enables position sharing
* Increases max stack size of stackable items to 999
* Increases max capacity of Smelter-like objects by 5x
* No fuel usage on fireplace type objects

### Difficulty Increases
* Increases normal enemy health by 2x
* Increases boss health by 1.5x
* Prevents most non-equippable or food items from being teleported

### Server Handshaking
* Mod will only load connecting to a dedicated server with the same version installed
* Servers running this mod will only allow clients to connect if they also have the same version of the mod installed


## Installation

1. Backup your characters and worlds! Copy `C:\Users\<username>\AppData\LocalLow\IronGate\Valheim` somewhere just in case
2. Install [BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/) on client and/or server
3. Download latest release and copy `ValHardMode.dll` to `<Steam Location>\steamapps\common\Valheim\BepInEx\plugins`
4. Start game and/or server and enjoy!

## Known Issues

* When removing or disabling the mod, item stacks or ore/fuel in Smelter-type objects over the normal max amount will be lost