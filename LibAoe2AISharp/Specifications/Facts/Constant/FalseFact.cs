namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// false constant fact.
    /// </summary>
    public class FalseFact : AIFact
    {
        /// <inheritdoc/>
        public override string ToScript()
        {
            return "(false)";
        }
    }
}