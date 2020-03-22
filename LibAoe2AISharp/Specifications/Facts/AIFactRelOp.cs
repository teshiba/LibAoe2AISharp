using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Abstract class of Fact with relational operator.
    /// </summary>
    public abstract class AIFactRelOp : AIFact
    {
        private readonly player_number? playerNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="AIFactRelOp"/> class.
        /// </summary>
        /// <param name="ope">relational operator.</param>
        /// <param name="value">compared value.</param>
        protected AIFactRelOp(relop ope, object value)
            : this(null, null, ope, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIFactRelOp"/> class.
        /// </summary>
        /// <param name="operand">left operand.</param>
        /// <param name="ope">relational operator.</param>
        /// <param name="value">compared value.</param>
        protected AIFactRelOp(object operand, relop ope, object value)
            : this(null, operand, ope, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIFactRelOp"/> class.
        /// </summary>
        /// <param name="playerNumber">player number.</param>
        /// <param name="operand">left operand.</param>
        /// <param name="ope">relational operator.</param>
        /// <param name="value">compared value.</param>
        protected AIFactRelOp(player_number? playerNumber, object operand, relop ope, object value)
        {
            this.playerNumber = playerNumber;
            Ope = ope;
            Value = value;
            Operand = operand;
        }

        /// <summary>
        /// Gets Operand.
        /// </summary>
        public object Operand { get; }

        /// <summary>
        /// Gets relational operator.
        /// </summary>
        public relop Ope { get; }

        /// <summary>
        /// Gets condition value.
        /// </summary>
        public object Value { get; }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(playerNumber, Operand, Ope.ToScript(), Value);
        }
    }
}