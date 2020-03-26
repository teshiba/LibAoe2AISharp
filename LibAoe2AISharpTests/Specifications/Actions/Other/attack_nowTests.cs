using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class attack_nowTests
    {
        [TestMethod]
        public void attack_nowTest()
        {
            // Arrange
            var expectedValue = "(attack-now)";

            // Act
            var testClass = new attack_now();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}