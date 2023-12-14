using System;
using System.Collections.Generic;
using System.Text;
using GameNetcodeStuff;
using HarmonyLib;

namespace ModTobe.Patches
{
    [HarmonyLib.HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void InfiniteSprintPatch(ref float ___sprintMeter)
        {
            ___sprintMeter = 1f;

        }

        
    }
}
