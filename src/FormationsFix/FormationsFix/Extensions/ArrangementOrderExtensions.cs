using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.MountAndBlade;
using System.Reflection;
using TaleWorlds.Core;

namespace FormationsFix.Extensions
{
    /// <summary>
    /// Exposes hidden methods, fileds, and properties of <see cref="ArrangementOrder"/> using Reflection
    /// </summary>
    internal static class ArrangementOrderExtensions
    {
        internal static void SetTickTimerField(this ArrangementOrder order, Timer timer)
        {
            var prop = order.GetType().GetField("tickTimer", BindingFlags.NonPublic | BindingFlags.Instance);
            prop.SetValue(order, timer);
        }

        internal static ArrangementOrderEnum GetOrderEnumField(this ArrangementOrder order)
        {
            var prop = typeof(ArrangementOrder).GetField("OrderEnum", BindingFlags.NonPublic | BindingFlags.Instance);
            object value = prop.GetValue(order);
            return (ArrangementOrderEnum)Enum.Parse(typeof(ArrangementOrderEnum), value.ToString());
        }

        internal static int GetUnitSpacingField(this ArrangementOrder order)
        {
            var prop = typeof(ArrangementOrder).GetField("_unitSpacing", BindingFlags.NonPublic | BindingFlags.Instance);
            object value = prop.GetValue(order);
            return int.Parse(value.ToString());
        }

        internal static void Rearrange(this ArrangementOrder order, Formation formation)
        {
            MethodInfo rearrangeMethod = order.GetType().GetMethod("Rearrange", BindingFlags.NonPublic | BindingFlags.Instance);
            rearrangeMethod.Invoke(order, new object[] { formation });
        }
        internal static void TickOccasionally(this ArrangementOrder order, Formation formation)
        {
            MethodInfo rearrangeMethod = order.GetType().GetMethod("TickOccasionally", BindingFlags.NonPublic | BindingFlags.Instance);
            rearrangeMethod.Invoke(order, new object[] { formation });
        }
    }

    /// <summary>
    /// Copied from <see cref="ArrangementOrder"/>
    /// </summary>
    internal enum ArrangementOrderEnum
    {
        Circle,
        Column,
        Line,
        Loose,
        Scatter,
        ShieldWall,
        Skein,
        Square,
    }
}
