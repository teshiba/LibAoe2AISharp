using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class chat_local_to_selfTests
    {
        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var message = "test message";
            var chat = new chat_local_to_self(message) {
                Comment = "test comment",
            };
            var expectedValue = "(chat-local-to-self \"" + message + "\") ;" + chat.Comment;

            // Act
            var actualValue = chat.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}