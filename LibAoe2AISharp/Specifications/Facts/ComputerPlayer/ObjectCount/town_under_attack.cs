namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact is set to true when a computer player's town is under attack.
    /// </summary>
    public class town_under_attack : AIFact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="town_under_attack"/> class.
        /// </summary>
        public town_under_attack()
        {
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(null);
        }
    }
}
