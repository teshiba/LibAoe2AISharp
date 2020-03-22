using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class set_goalTests
    {
        [TestMethod]
        public void set_goalTest()
        {
            // Arrange
            var expectedValue = "(set-goal 1 10)";

            // Act
            var testClass = new set_goal(1, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}