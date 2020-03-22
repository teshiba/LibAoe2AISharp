namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Display the string as a local chat message.
    /// Displayed only if the user is the same as the computer player sending the message.
    /// For debugging.
    /// </summary>
    public class chat_local_to_self : AIAction
    {
        private readonly string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="chat_local_to_self"/> class.
        /// </summary>
        /// <param name="message">Displayed message.</param>
        public chat_local_to_self(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Convert to AI script format.
        /// </summary>
        /// <returns>AI script.</returns>
        public override string ToScript()
        {
            return ToScript("\"" + message + "\"");
        }
    }
}
