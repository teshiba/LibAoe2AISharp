using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class game_timeTests
    {
        [TestMethod]
        public void game_timeTest()
        {
            // Arrange
            var expectedValue = "(game-time == 10)";

            // Act
            var testClass = new game_time(Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}