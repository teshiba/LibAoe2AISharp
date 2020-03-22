namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// The fact checks that the unit is available to the computer player's civ,
    /// and that the tech tree prerequisites for training the unit are met.
    /// <para>
    /// The fact does not check whether the unit training can start.
    /// This depends on resource availability, housing headroom, and
    /// whether building needed for training is currently used for research/training of another unit.
    /// </para>
    /// The fact allows the use of unit line wildcard parameters for the "unit".
    /// </summary>
    public class unit_available : AIFact
    {
        private readonly unit unit;

        /// <summary>
        /// Initializes a new instance of the <see cref="unit_available"/> class.
        /// </summary>
        /// <param name="unit">unit.</param>
        public unit_available(unit unit)
        {
            this.unit = unit;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(unit);
        }
    }
}
