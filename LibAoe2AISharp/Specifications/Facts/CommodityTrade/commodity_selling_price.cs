using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks the current selling price for the given commodity.
    /// </summary>
    public class commodity_selling_price : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="commodity_selling_price"/> class.
        /// </summary>
        /// <param name="commodity">commodity.</param>
        /// <param name="ope">relational operator.</param>
        /// <param name="value">price.</param>
        public commodity_selling_price(commodity commodity, relop ope, short value)
            : base(commodity, ope, value)
        {
        }
    }
}
