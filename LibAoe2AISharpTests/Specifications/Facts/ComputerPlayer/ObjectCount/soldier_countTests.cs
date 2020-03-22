using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class soldier_countTests
    {
        [TestMethod]
        public void soldier_countTest()
        {
            // Arrange
            var expectedValue = "(soldier-count == 20) ;soldier count eq 20";

            // Act
            var testClass = new soldier_count(relop.eq, 20);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}