using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Utilty.Tests
{
    [TestClass]
    public class DebugTests
    {
        [TestMethod]
        [DataRow(false, false, false)]
        [DataRow(false, false, true)]
        [DataRow(false, true, false)]
        [DataRow(false, true, true)]
        [DataRow(true, false, false)]
        [DataRow(true, false, true)]
        [DataRow(true, true, false)]
        [DataRow(true, true, true)]
        public void ToScriptTestAllSettings(
            bool chatLocalToSelf,
            bool chatToAll,
            bool developerChatLocalToSelf)
        {
            // Arrange
            Debug.ChatLocalToSelf = chatLocalToSelf;
            Debug.ChatToAll = chatToAll;
            Debug.DeveloperChatLocalToSelf = developerChatLocalToSelf;

            Debug debugAction = new Debug();
            var className = "testClassName";
            var debugMessage = "debug test message";
            var expectedScript = string.Empty;

            if (Debug.ChatLocalToSelf) {
                expectedScript += "    (chat-local-to-self \"" + debugMessage + "\")" + Environment.NewLine;
            } else if (Debug.ChatToAll) {
                expectedScript += "    (chat-to-all \"" + debugMessage + "\")" + Environment.NewLine;
            }

            if (Debug.DeveloperChatLocalToSelf) {
                expectedScript += "    (chat-local-to-self \"[dbg]" + className + "\")" + Environment.NewLine;
            }

            // Act
            var actualScript = debugAction.ToScript(className, debugMessage);

            // Assert
            Assert.AreEqual(expectedScript, actualScript);

            // after
            Debug.ChatLocalToSelf = false;
            Debug.ChatToAll = false;
            Debug.DeveloperChatLocalToSelf = false;
        }
    }
}