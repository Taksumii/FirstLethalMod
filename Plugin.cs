using BepInEx;
using GameNetcodeStuff;
using HarmonyLib;
using System;

namespace ModTobe
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class ControllerPatch : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");


            Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);

            harmony.PatchAll(typeof(ControllerPatch));
            harmony.PatchAll(typeof(Patches.PlayerControllerBPatch));
            harmony.PatchAll(typeof(Patches.SprayPaintPatch));
            harmony.PatchAll(typeof(Patches.BillyHassanBrackenPatch));


        }
    }

    
}

