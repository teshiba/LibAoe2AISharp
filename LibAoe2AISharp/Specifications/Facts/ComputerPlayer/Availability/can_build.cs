namespace LibAoe2AISharp.Specifications
{
    using LibAoe2AISharp.Utilty;

    /// <summary>
    /// This fact checks whether the computer player can build the given building.
    /// </summary>
    public class can_build : AIFact
    {
        private readonly building building;

        /// <summary>
        /// Initializes a new instance of the <see cref="can_build"/> class.
        /// </summary>
        /// <param name="building">Type of building.</param>
        public can_build(building building)
        {
            this.building = building;
            Comment = "Can build " + building.ToLocalLang() + "?";
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(building);
        }
    }
}
