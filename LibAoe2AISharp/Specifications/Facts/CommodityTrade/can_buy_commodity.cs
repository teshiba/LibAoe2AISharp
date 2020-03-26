namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks whether the computer player can buy one lot of the given commodity.
    /// The fact does not take into account escrowed resources.
    /// </summary>
    public class can_buy_commodity : AIFact
    {
        private readonly commodity commodity;

        /// <summary>
        /// Initializes a new instance of the <see cref="can_buy_commodity"/> class.
        /// </summary>
        /// <param name="commodity">commodity.</param>
        public can_buy_commodity(commodity commodity)
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
