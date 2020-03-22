namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Send the string as a chat message to all players.
    /// </summary>
    /// <remarks>
    /// chat-to-all command.
    /// </remarks>
    public class chat_to_all : AIAction
    {
        private readonly string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="chat_to_all"/> class.
        /// </summary>
        /// <param name="message">Displayed message.</param>
        public chat_to_all(string message)
        {
            this.message = message;
        }

        /// <inheritdoc/>
        public override string ToScript()
        {
            return ToScript("\"" + message + "\"");
        }
    }
}
