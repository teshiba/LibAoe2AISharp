namespace LibAoe2AISharp.Utilty
{
    using LibAoe2AISharp.Specifications;

    /// <summary>
    /// Actions for debug.
    /// </summary>
    public class Debug : IDebug
    {
        private readonly string debugPrefix = "[dbg]";

        private readonly ActionCollection debugActions = new ();

        /// <summary>
        /// Gets or sets a value indicating whether enable debug message.
        /// If the conditions for the defrule are met,
        /// display the message by chat-local-to-self command.
        /// </summary>
        public static bool ChatLocalToSelf { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether enable debug message.
        /// But if ChatLocalToSelf is true, this value is ignored.
        /// If the conditions for the defrule are met,
        /// display the message by chat-to-all command.
        /// </summary>
        public static bool ChatToAll { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether enable debug message for developers.
        /// If the conditions for the defrule are met,
        /// display the message by chat-local-to-self command.
        /// </summary>
        public static bool DeveloperChatLocalToSelf { get; set; }

        /// <summary>
        /// Convert to ai script format.
        /// </summary>
        /// <param name="className">Debug target class name.</param>
        /// <param name="message">Displayed string as debug message.</param>
        /// <returns>ai script.</returns>
        public string ToScript(string className, string message)
        {
            if (ChatLocalToSelf) {
                debugActions.Add(new chat_local_to_self(message));
            } else if (ChatToAll) {
                debugActions.Add(new chat_to_all(message));
            }

            if (DeveloperChatLocalToSelf) {
                debugActions.Add(new chat_local_to_self($"{debugPrefix}{className}"));
            }

            string ret = string.Empty;

            if (debugActions.Count != 0) {
                ret = debugActions.ToScript();
            }

            return ret;
        }
    }
}
