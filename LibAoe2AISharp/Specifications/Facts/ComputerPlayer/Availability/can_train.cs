namespace LibAoe2AISharp.Specifications
{
    using LibAoe2AISharp.Utilty;

    /// <summary>
    /// This fact checks if the training of the given unit can start.
    /// </summary>
    public class can_train : AIFact
    {
        private readonly unit unit;

        /// <summary>
        /// Initializes a new instance of the <see cref="can_train"/> class.
        /// </summary>
        /// <param name="unit">Unit type.</param>
        public can_train(unit unit)
        {
            this.unit = unit;
            Comment = "Can train " + unit.ToLocalLang() + "?";
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(unit);
        }
    }
}
