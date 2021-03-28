namespace LibAoe2AISharp.Specifications
{
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// This fact checks the given player's building count.
    /// Both existing buildings and buildings under construction of the given type are included.
    /// The computer player relies only on what it has seen – no cheating.
    /// </summary>
    public class players_building_type_count : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="players_building_type_count"/> class.
        /// </summary>
        /// <param name="playerNumber">player number.</param>
        /// <param name="building">building.</param>
        /// <param name="ope">operator.</param>
        /// <param name="value">building count.</param>
        public players_building_type_count(
            player_number playerNumber,
            building building,
            relop ope,
            short value)
            : base(playerNumber, building, ope, value)
        {
        }
    }
}
