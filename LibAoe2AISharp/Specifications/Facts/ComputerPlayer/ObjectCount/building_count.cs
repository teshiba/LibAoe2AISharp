namespace LibAoe2AISharp.Specifications
{
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// This fact checks the computer player's building count.
    /// Only existing buildings are included.
    /// </summary>
    public class building_count : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="building_count"/> class.
        /// </summary>
        /// <param name="ope">Relational operator.</param>
        /// <param name="value"> building count.</param>
        public building_count(relop ope, short value)
            : base(ope, value)
        {
        }
    }
}
