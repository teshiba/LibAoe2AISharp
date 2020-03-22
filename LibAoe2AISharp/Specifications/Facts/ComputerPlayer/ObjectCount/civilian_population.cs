using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the computer player's civilian population.
    /// <para>
    /// The civilian population is villagers, trade vehicles, fishing boats, etc.
    /// </para>
    /// </summary>
    public class civilian_population : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="civilian_population"/> class.
        /// </summary>
        /// <param name="ope">Relational operator.</param>
        /// <param name="value">evaluation value.</param>
        public civilian_population(relop ope, int value)
            : base(ope, value)
        {
        }
    }
}