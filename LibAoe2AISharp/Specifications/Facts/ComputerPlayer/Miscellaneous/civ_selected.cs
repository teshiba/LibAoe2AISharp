namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the computer player's civ.
    /// </summary>
    public class civ_selected : AIFact
    {
        private readonly civ civ;

        /// <summary>
        /// Initializes a new instance of the <see cref="civ_selected"/> class.
        /// </summary>
        /// <param name="civ">player's civ.</param>
        public civ_selected(civ civ)
        {
            this.civ = civ;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(civ);
        }
    }
}