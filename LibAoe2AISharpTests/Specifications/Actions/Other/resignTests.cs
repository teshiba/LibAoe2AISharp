using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class resignTests
    {
        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var expectedValue = "(resign)";

            // Act
            var testClass = new resign();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}