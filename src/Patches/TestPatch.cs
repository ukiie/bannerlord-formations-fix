using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.MountAndBlade;

namespace FormationsFix.Patches
{
    [HarmonyPatch(typeof(SkeinFormation), nameof(SkeinFormation.Clone))]
    internal static class TestPatch
    {
        private static void Clone(ref IFormationArrangement __result, IFormation formation)
        {
            __result = new SkeinFormation(formation);
        }
    }
}
