namespace LibAoe2AISharp.Specifications
{
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// This fact checks the game time.
    /// </summary>
    public class game_time : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="game_time"/> class.
        /// </summary>
        /// <param name="ope">relational operator.</param>
        /// <param name="second">value of seconds.</param>
        public game_time(relop ope, int second)
            : base(ope, second)
        {
        }
    }
}