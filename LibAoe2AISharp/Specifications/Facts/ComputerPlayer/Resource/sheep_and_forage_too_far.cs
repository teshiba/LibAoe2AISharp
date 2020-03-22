namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks whether the computer player has any forage site(s) and/or sheep
    /// within 8 tiles of the drop-off location (Mill or Town Center).
    /// </summary>
    public class sheep_and_forage_too_far : AIFact
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="sheep_and_forage_too_far"/> class.
        /// </summary>
        public sheep_and_forage_too_far()
        {
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript(null);
        }
    }
}