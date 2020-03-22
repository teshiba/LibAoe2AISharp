using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the given player's unit count.
    /// The computer player relies only on what it has seen no cheating.
    /// For allies and self only trained units are included.
    /// </summary>
    public class players_unit_count : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="players_unit_count"/> class.
        /// </summary>
        /// <param name="playerNumber">player number.</param>
        /// <param name="ope">operation.</param>
        /// <param name="value">unit count.</param>
        public players_unit_count(player_number playerNumber, relop ope, short value)
            : base(playerNumber, ope, value)
        {
        }
    }
}
