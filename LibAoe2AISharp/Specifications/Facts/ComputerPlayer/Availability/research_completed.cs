namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks that the given research is completed.
    /// </summary>
    public class research_completed : AIFact
    {
        private readonly ri researchItem;
        private readonly bool isResearchItemEnum;

        /// <summary>
        /// Initializes a new instance of the <see cref="research_completed"/> class.
        /// </summary>
        /// <param name="researchItem">research item.</param>
        public research_completed(ri researchItem)
        {
            this.researchItem = researchItem;
            isResearchItemEnum = researchItem.IsResearchItemEnum();
       }

        /// <inheritdoc/>
        public override string ToScript()
        {
            var riPrefix = string.Empty;

            if (isResearchItemEnum) {
                riPrefix = "ri-";
            }

            return ToScript(riPrefix + researchItem);
        }
    }
}
