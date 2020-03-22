namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks whether the computer player has found the given resource.
    /// </summary>
    public class resource_found : AIFact
    {
        private readonly resource_type resourceType;

        /// <summary>
        /// Initializes a new instance of the <see cref="resource_found"/> class.
        /// </summary>
        /// <param name="resourceType">Resource type.</param>
        public resource_found(resource_type resourceType)
        {
            this.resourceType = resourceType;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(resourceType);
        }
    }
}