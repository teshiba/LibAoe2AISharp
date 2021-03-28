namespace LibAoe2AISharp.Specifications
{
    using LibAoe2AISharp.Utilty;

    /// <summary>
    /// This action sets a given strategic number to a given value.
    /// <para>
    /// See <see cref="sn"/> for information on strategic numbers.
    /// </para>
    /// </summary>
    public class set_strategic_number : AIAction
    {
        private readonly sn strategicNumber;
        private readonly int value;

        /// <summary>
        /// Initializes a new instance of the <see cref="set_strategic_number"/> class.
        /// </summary>
        /// <param name="strategicNumber">Strategic number.</param>
        /// <param name="value">set value.</param>
        public set_strategic_number(sn strategicNumber, int value)
        {
            this.value = value;
            this.strategicNumber = strategicNumber;
            Comment = strategicNumber.ToLocalLang();
        }

        /// <summary>
        /// Convert to AI script format.
        /// </summary>
        /// <returns>AI script.</returns>
        public override string ToScript()
        {
            return ToScript(strategicNumber.GetType().Name + "-" + strategicNumber, value);
        }
    }
}