using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class civilian_populationTests
    {
        [TestMethod]
        public void civilian_populationTest()
        {
            // Arrange
            var expectedValue = "(civilian-population == 10)";

            // Act
            var testClass = new civilian_population(Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}