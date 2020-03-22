namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action buys one lot of the given commodity.
    /// </summary>
    public class buy_commodity : AIAction
    {
        private readonly commodity commodity;

        /// <summary>
        /// Initializes a new instance of the <see cref="buy_commodity"/> class.
        /// </summary>
        /// <param name="commodity">commodity.</param>
        public buy_commodity(commodity commodity)
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
