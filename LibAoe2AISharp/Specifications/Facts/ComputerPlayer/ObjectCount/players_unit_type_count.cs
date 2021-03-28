namespace LibAoe2AISharp.Specifications
{
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// This fact checks the given player's unit count.
    /// The computer player relies only on what it has seen no cheating.
    /// For allies and self only trained units of the given type are included.
    /// </summary>
    public class players_unit_type_count : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="players_unit_type_count"/> class.
        /// </summary>
        /// <param name="playerNumber">player number.</param>
        /// <param name="unit">unit.</param>
        /// <param name="ope">operation.</param>
        /// <param name="value">unit count.</param>
        public players_unit_type_count(player_number playerNumber, unit unit, relop ope, short value)
            : base(playerNumber, unit, ope, value)
        {
        }
    }
}
