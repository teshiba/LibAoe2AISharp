namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action sells one lot of a given commodity.
    /// </summary>
    public class sell_commodity : AIAction
    {
        private readonly commodity commodity;

        /// <summary>
        /// Initializes a new instance of the <see cref="sell_commodity"/> class.
        /// </summary>
        /// <param name="commodity">commodity.</param>
        public sell_commodity(commodity commodity)
        {
            this.commodity = commodity;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(commodity);
        }
    }
}
