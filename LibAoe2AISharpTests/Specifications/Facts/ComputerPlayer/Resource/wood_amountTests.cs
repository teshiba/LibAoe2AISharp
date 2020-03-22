using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class wood_amountTests
    {
        [TestMethod]
        public void wood_amountTest()
        {
            // Arrange
            var expectedValue = 100;
            var expectedOpe = relop.gt;

            // Act
            var testClass = new wood_amount(expectedOpe, expectedValue);
            var actualValue = testClass.Value;
            var actualOpe = testClass.Ope;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedOpe, actualOpe);
        }
    }
}