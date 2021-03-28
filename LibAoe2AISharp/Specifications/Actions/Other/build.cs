namespace LibAoe2AISharp.Specifications
{
    using LibAoe2AISharp.Utilty;

    /// <summary>
    /// This action builds the given building.
    /// </summary>
    public class build : AIAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="build"/> class.
        /// </summary>
        /// <param name="building">building.</param>
        public build(building building)
        {
            Building = building;
            Comment = "Build " + building.ToLocalLang();
        }

        /// <summary>
        /// Gets build target object.
        /// </summary>
        public building Building { get; }

        /// <summary>
        /// Convert to AI script format.
        /// </summary>
        /// <returns>AI script.</returns>
        public override string ToScript()
        {
            return ToScript(Building);
        }
    }
}