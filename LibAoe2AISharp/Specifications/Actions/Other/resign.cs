namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This action causes the computer player to resign.
    /// </summary>
    public class resign : AIAction
    {
        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(null);
        }
    }
}
