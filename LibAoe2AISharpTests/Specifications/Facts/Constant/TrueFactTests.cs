using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class TrueFactTests
    {
        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var condition = new TrueFact();

            var expectedValue = "(true)";

            // Act
            var actualValue = condition.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}