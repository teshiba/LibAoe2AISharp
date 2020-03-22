using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks computer player's housing headroom.
    /// <para>
    /// Housing headroom is the difference between current housing capacity and trained unit capacity.
    /// </para>
    /// </summary>
    public class housing_headroom : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="housing_headroom"/> class.
        /// </summary>
        /// <param name="ope">Relational operator.</param>
        /// <param name="capacity">remaining populations capacity.</param>
        public housing_headroom(relop ope, int capacity)
            : base(ope, capacity)
        {
            Comment = "checks remaining populations capacity";
        }
    }
}