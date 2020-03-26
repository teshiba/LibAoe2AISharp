using LibAoe2AISharp.Utilty;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action trains the given unit.
    /// </summary>
    public class train : AIAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="train"/> class.
        /// </summary>
        /// <param name="unit">Unit.</param>
        public train(unit unit)
        {
            Unit = unit;
            Comment = "Train " + unit.ToLocalLang();
        }

        /// <summary>
        /// Gets <see cref="unit"/>.
        /// </summary>
        public unit Unit { get; }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(Unit);
        }
    }
}
