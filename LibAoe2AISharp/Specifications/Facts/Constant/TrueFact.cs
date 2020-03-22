namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// true constant fact.
    /// </summary>
    public class TrueFact : AIFact
    {
        /// <inheritdoc/>
        public override string ToScript()
        {
            return "(true)";
        }
    }
}