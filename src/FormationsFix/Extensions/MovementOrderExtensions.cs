using FormationsFix.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.MountAndBlade;

namespace FormationsFix.Extensions
{
    internal static class MovementOrderExtensions
    {
        internal static MovementOrderEnum GetOrderEnumField(this MovementOrder order)
        {
            var prop = typeof(MovementOrder).GetField("OrderEnum", BindingFlags.NonPublic | BindingFlags.Instance);
            object value = prop.GetValue(order);
            return (MovementOrderEnum)Enum.Parse(typeof(MovementOrderEnum), value.ToString());
        }
    }

    /// <summary>
    /// Copied from <see cref="MovementOrder"/>
    /// </summary>
    internal enum MovementOrderEnum
    {
        Invalid,
        Attach,
        AttackEntity,
        Charge,
        ChargeToTarget,
        Follow,
        FollowEntity,
        Guard,
        Move,
        Retreat,
        Stop,
        Advance,
        FallBack,
    }

}
