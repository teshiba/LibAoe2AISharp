using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class chat_to_allTests
    {
        [TestMethod]
        public void chat_to_allTest()
        {
            // Arrange
            var message = "test message";
            var chat = new chat_to_all(message) {
                Comment = "test comment",
            };
            var expectedValue = "(chat-to-all \"" + message + "\") ;" + chat.Comment;

            // Act
            var actualValue = chat.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}