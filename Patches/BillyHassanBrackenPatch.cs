using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using BepInEx;
using HarmonyLib;
using LC_API.BundleAPI;
using UnityEngine;
using UnityEngine.Video;



namespace ModTobe.Patches
{
    [HarmonyPatch]
    internal class BillyHassanBrackenPatch
    {
        [HarmonyPatch(typeof(FlowermanAI), "Start")]
        [HarmonyPostfix]
        public static void SummonGok(FlowermanAI __instance)
        {
            
            __instance.creatureAngerVoice.clip = BundleLoader.GetLoadedAsset<AudioClip>("assets/ultra.mp3");
            __instance.crackNeckSFX = BundleLoader.GetLoadedAsset<AudioClip>("assets/mods.mp3");
            __instance.crackNeckAudio.clip = BundleLoader.GetLoadedAsset<AudioClip>("assets/mods.mp3");
            Object.Destroy(
                (Object)(object)((Component)((Component)__instance).gameObject.transform.Find("FlowermanModel")
                    .Find("LOD1")).gameObject.GetComponent<SkinnedMeshRenderer>());
            GameObject val = Object.Instantiate<GameObject>(
                BundleLoader.GetLoadedAsset<GameObject>("bundles/Hassan.png"),
                ((Component)__instance).gameObject.transform);
            val.transform.localPosition = new Vector3(0f, 1.5f, 0f);
        }
    }

    [HarmonyPatch]
    internal class TerminalPatches
    {
        [HarmonyPatch(typeof(Terminal), "Awake")]
        [HarmonyPostfix]
        public static void EditTerminal(Terminal __instance)
        {
            __instance.enemyFiles[1].displayVideo = BundleLoader.GetLoadedAsset<VideoClip>("assets/Gok.m4v");
        }
    }
}