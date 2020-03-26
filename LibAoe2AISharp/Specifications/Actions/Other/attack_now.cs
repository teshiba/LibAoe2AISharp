namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action forces attack with currently available attack units.
    /// Units are designated as attack units by using sn-percent-attack-soldiers or sn-percent-attack-boats.
    /// </summary>
    public class attack_now : AIAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="attack_now"/> class.
        /// </summary>
        public attack_now()
        {
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(null);
        }
    }
}