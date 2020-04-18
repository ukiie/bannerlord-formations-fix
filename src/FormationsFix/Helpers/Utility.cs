using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Core;
using TaleWorlds.Library;

namespace FormationsFix.Helpers
{
    internal static class Utility
    {
        internal static void DisplayText(string text, DisplayTextStyle displayTextStyle = DisplayTextStyle.Normal)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            InformationManager.DisplayMessage(new InformationMessage(text, displayTextStyle.GetColorFromDsiplayTextStyle()));
        }

        internal static Color GetColorFromDsiplayTextStyle(this DisplayTextStyle displayTextStyle)
        {
            switch (displayTextStyle)
            {
                case DisplayTextStyle.Info:
                    return new Color(0, 0, 1);
                case DisplayTextStyle.Warning:
                    return new Color(1, 0, 0);
                default:
                    return Color.White;
            }
        }
    }

    public enum DisplayTextStyle
    {
        Normal,
        Info,
        Warning
    }
}
