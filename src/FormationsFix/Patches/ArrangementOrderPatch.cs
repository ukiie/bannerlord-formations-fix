using FormationsFix.CopiedLogic;
using FormationsFix.Extensions;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TaleWorlds.Core;
using TaleWorlds.Engine;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;

namespace FormationsFix.Patches
{
    [HarmonyPatch(typeof(ArrangementOrder), "OnApply")]
    internal static class ArrangementOrderOnApplyPatch
    {
        private static void OnApply(ref ArrangementOrder __instance, Formation formation)
        {
            var instanceOrderEnum = __instance.GetOrderEnumField();
            var formationOrderEnum = formation.MovementOrder.GetOrderEnumField();

            formation.SetPositioning(new WorldPosition?(), new Vec2?(), new int?(__instance.GetUnitSpacingField()));
            __instance.Rearrange(formation);

            if (instanceOrderEnum == ArrangementOrderEnum.Scatter)
                __instance.TickOccasionally(formation);

            foreach (Agent agent in formation.Units.Where(u => u.IsAIControlled))
            {
                Agent.UsageDirection shieldDirectionOfUnit = __instance.GetShieldDirectionOfUnit(formation, agent);
                agent.EnforceShieldUsage(shieldDirectionOfUnit);
            }

            if (formationOrderEnum != MovementOrderEnum.Charge && formationOrderEnum != MovementOrderEnum.ChargeToTarget)
            {
                if (instanceOrderEnum != ArrangementOrderEnum.Circle && instanceOrderEnum != ArrangementOrderEnum.ShieldWall && instanceOrderEnum != ArrangementOrderEnum.Square && instanceOrderEnum != ArrangementOrderEnum.Column)
                {
                    foreach (Agent unit in formation.Units)
                        MovementOrderMethods.SetDefaultMoveBehaviorValues(unit);
                }
                else if (instanceOrderEnum != ArrangementOrderEnum.Column)
                {
                    foreach (Agent unit in formation.Units)
                        MovementOrderMethods.SetDefensiveArrangementMoveBehaviorValues(unit);
                }
                else
                {
                    foreach (Agent unit in formation.Units)
                        MovementOrderMethods.SetFollowBehaviorValues(unit);
                }
            }

            __instance.SetTickTimerField(new Timer(MBCommon.GetTime(MBCommon.TimeType.Mission), 0.5f, true));
        }
    }
}
