using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class building_countTests
    {
        [TestMethod]
        public void building_countTest()
        {
            // Arrange
            var expectedValue = "(building-count == 10)";

            // Act
            var testClass = new building_count(relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}