using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;



namespace ModTobe.Patches;

[BepInPlugin("GUID", "Name", "1.0")]


[HarmonyPatch(typeof(SprayPaintItem))]
internal class SprayPaintPatch
{
    [HarmonyPatch("LateUpdate")]
    [HarmonyPostfix]
    private static void sprayPaintPatch(ref float ___sprayCanTank, ref float ___sprayCanShakeMeter)
    {
        ___sprayCanTank = 1f;

        ___sprayCanShakeMeter = 1f;

    }
}