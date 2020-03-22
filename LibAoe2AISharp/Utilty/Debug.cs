using LibAoe2AISharp.Specifications;

namespace LibAoe2AISharp.Utilty
{
    /// <summary>
    /// Actions for debug.
    /// </summary>
    public class Debug : IDebug
    {
        private readonly string debugPrefix = "[dbg]";

        private readonly ActionCollection debugActions = new ActionCollection();

        /// <summary>
        /// Gets or sets a value indicating whether enable debug message.
        /// If the conditions for the defrule are met,
        /// display the message by chat-local-to-self command.
        /// </summary>
        public static bool ChatLocalToSelf { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether enable debug message.
        /// But if ChatLocalToSelf is true, this value is ignored.
        /// If the conditions for the defrule are met,
        /// display the message by chat-to-all command.
        /// </summary>
        public static bool ChatToAll { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether enable debug message for developers.
        /// If the conditions for the defrule are met,
        /// display the message by chat-local-to-self command.
        /// </summary>
        public static bool DeveloperChatLocalToSelf { get; set; } = false;

        /// <summary>
        /// Convert to ai script format.
        /// </summary>
        /// <param name="className">Debug target class name.</param>
        /// <param name="debugMessage">Displayed string as debug message.</param>
        /// <returns>ai script.</returns>
        public string ToScript(string className, string debugMessage)
        {
            if (ChatLocalToSelf) {
                debugActions.Add(new chat_local_to_self(debugMessage));
            } else if (ChatToAll) {
                debugActions.Add(new chat_to_all(debugMessage));
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
