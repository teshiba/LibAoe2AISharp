namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action disables the rule that it is part of.
    /// <para>
    /// A defrule with the action will only be executed once and not executed next.
    /// </para>
    /// </summary>
    public class disable_self : AIAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="disable_self"/> class.
        /// </summary>
        public disable_self()
        {
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(null);
        }
    }
}