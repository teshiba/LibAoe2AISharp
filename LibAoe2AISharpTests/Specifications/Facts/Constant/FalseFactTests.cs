using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class FalseFactTests
    {
        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var condition = new FalseFact();

            var expectedValue = "(false)";

            // Act
            var actualValue = condition.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}