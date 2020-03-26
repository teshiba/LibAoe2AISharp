using LibAoe2AISharp.Framework;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the completion percentage for a given perimeter wall.
    /// <para>
    /// Trees and other destructible natural barriers are included and count as completed.
    /// </para>
    /// </summary>
    public class wall_completed_percentage : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="wall_completed_percentage"/> class.
        /// </summary>
        /// <param name="perimeter">valid wall perimeter.</param>
        /// <param name="ope">relational operator.</param>
        /// <param name="percentage">completion percentage.</param>
        public wall_completed_percentage(Perimeter perimeter, relop ope, short percentage)
            : base((int)perimeter, ope, percentage)
        {
        }
    }
}
