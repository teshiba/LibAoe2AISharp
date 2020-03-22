using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class trainTests
    {
        [TestMethod]
        public void trainTest()
        {
            // Arrange
            var expectedUnit = unit.archer;

            // Act
            var testClass = new train(expectedUnit);
            var actualUnit = testClass.Unit;

            // Assert
            Assert.AreEqual(expectedUnit, actualUnit);
        }

        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var expectedUnit = unit.archer;

            // Act
            var testClass = new train(expectedUnit);
            var actualValue = testClass.ToScript();
            var expectedValue = "(train archer) ;" + testClass.Comment;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}