namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks if the given player is a valid player and still playing.
    /// </summary>
    public class player_in_game : AIFact
    {
        private readonly player_number playerNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="player_in_game"/> class.
        /// </summary>
        /// <param name="playerNumber">player number.</param>
        public player_in_game(player_number playerNumber)
        {
            this.playerNumber = playerNumber;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(playerNumber);
        }
    }
}