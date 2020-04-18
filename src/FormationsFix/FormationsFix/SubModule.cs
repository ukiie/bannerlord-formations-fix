using FormationsFix.Behaviors;
using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace FormationsFix
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
#if DEBUG
            Harmony.DEBUG = true;
#endif
            Harmony harmony = new Harmony("com.ukie.formationsfix");

            harmony.PatchAll(typeof(SubModule).Assembly);
            var originalMethods = harmony.GetPatchedMethods();

        }

        public override void OnMissionBehaviourInitialize(Mission mission)
        {
            if (mission.CombatType == Mission.MissionCombatType.Combat)
            {
                mission.AddMissionBehaviour(new CustomMissionLogic());
            }
            base.OnMissionBehaviourInitialize(mission);
        }
    }
}
