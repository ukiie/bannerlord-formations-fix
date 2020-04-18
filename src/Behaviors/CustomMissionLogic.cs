using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TaleWorlds.InputSystem;
using TaleWorlds.MountAndBlade;
using FormationsFix.Helpers;

namespace FormationsFix.Behaviors
{
    internal sealed class CustomMissionLogic : MissionLogic
    {
        public CustomMissionLogic() : base() { }

        public override void OnMissionTick(float dt)
        {
            if (Input.IsKeyPressed(InputKey.F10))
            {
                Utility.DisplayText("Normal text");
            }
            if (Input.IsKeyPressed(InputKey.F11))
            {
                Utility.DisplayText("Info text", DisplayTextStyle.Info);
            }
            if (Input.IsKeyPressed(InputKey.F12))
            {
                Utility.DisplayText("Warning text", DisplayTextStyle.Warning);
            }
            base.OnMissionTick(dt);
        }
    }
}
