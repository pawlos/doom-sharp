# DooM#

This is a port of the [DooM source code](https://github.com/id-Software/DOOM/tree/master/linuxdoom-1.10) to C#, currently targeting .NET 6

## Getting started

* Make sure you have the .NET 6 SDK installed: https://dotnet.microsoft.com/en-us/download .

* Install [Visual Studio 2022](https://visualstudio.microsoft.com/downloads), there's a free community edition available, or use [VS Code](https://code.visualstudio.com/) if you want a lightweight editor. You can also check out [Rider](https://www.jetbrains.com/rider) from JetBrains if you're more familiar with IntelliJ.

* Fork or clone this repo (duh).

* Open the `src/DoomSharp.sln` file and set the DoomSharp.Windows project as your startup project.

* Before running, you need some WAD files. If you have an original copy of DooM, you can use these files. If not, you can freely download the shareware WAD from Wad Archive: https://www.wad-archive.com/wad/Doom-Shareware-v1.9

* Once you have your WAD files in a directory - I prefer to use a directory called WAD in the repository's folder structure - , open the DoomSharp.Windows project properties and add a debug profile. In this debug profile, add an environment variable called `DOOMWADDIR` and set its value to the path that contains the WAD file(s).
This should give you a file called `launchSettings.json` which looks like this:
```json
{
  "profiles": {
    "DoomSharp.Windows": {
      "commandName": "Project",
      "environmentVariables": {
        "DOOMWADDIR": "Path\\To\\Wads"
      }
    }
  }
}
```

## Progress
Loading the original WAD files should work, although I've only tested the shareware WAD for now. When running, the game loop starts and switches between the title screen, credits and help screen (depending on the game version/WAD files).

The menu system has also already been implemented, you can access it while running the game by pressing the ESC key. Not all options have been implemented yet, they may change visually but not yet trigger actual actions.
Starting a new game currently crashes.

Next step is to implement playing back demo's so that the startup experience is complete.
