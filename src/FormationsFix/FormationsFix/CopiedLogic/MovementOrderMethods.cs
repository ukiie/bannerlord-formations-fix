using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.MountAndBlade;

namespace FormationsFix.CopiedLogic
{
    /// <summary>
    /// Static internal methods copied from <see cref="MovementOrder"/>
    /// </summary>
    internal static class MovementOrderMethods
    {
        internal static void SetDefensiveArrangementMoveBehaviorValues(Agent unit)
        {
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.GoToPos, 3f, 8f, 5f, 20f, 6f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.Melee, 4f, 5f, 0.0f, 20f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.Ranged, 0.0f, 7f, 0.0f, 20f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.ChargeHorseback, 0.0f, 7f, 0.0f, 30f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.RangedHorseback, 0.0f, 15f, 0.0f, 30f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.AttackEntityMelee, 5f, 12f, 7.5f, 30f, 4f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.AttackEntityRanged, 0.55f, 12f, 0.8f, 30f, 0.45f);
        }

        internal static void SetFollowBehaviorValues(Agent unit)
        {
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.GoToPos, 3f, 7f, 5f, 20f, 6f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.Melee, 6f, 7f, 4f, 20f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.Ranged, 0.0f, 7f, 0.0f, 20f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.ChargeHorseback, 0.0f, 7f, 0.0f, 30f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.RangedHorseback, 0.0f, 15f, 0.0f, 30f, 0.0f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.AttackEntityMelee, 5f, 12f, 7.5f, 30f, 4f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.AttackEntityRanged, 0.55f, 12f, 0.8f, 30f, 0.45f);
        }

        internal static void SetDefaultMoveBehaviorValues(Agent unit)
        {
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.GoToPos, 3f, 7f, 5f, 20f, 6f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.Melee, 8f, 7f, 5f, 20f, 0.01f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.Ranged, 0.02f, 7f, 0.04f, 20f, 0.03f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.ChargeHorseback, 10f, 7f, 5f, 30f, 0.05f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.RangedHorseback, 0.02f, 15f, 0.065f, 30f, 0.055f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.AttackEntityMelee, 5f, 12f, 7.5f, 30f, 4f);
            unit.SetAIBehaviorValues(AISimpleBehaviorKind.AttackEntityRanged, 0.55f, 12f, 0.8f, 30f, 0.45f);
        }
    }
}
