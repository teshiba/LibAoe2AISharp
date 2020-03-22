using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class AIActionTests
    {
        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var testAIAction = new TestAIAction {
                Comment = "test comment",
            };
            var expectedScript = "(TestAIAction testParam1 testParam2) ;test comment";

            // Act
            var actualScript = testAIAction.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
        }
    }
}