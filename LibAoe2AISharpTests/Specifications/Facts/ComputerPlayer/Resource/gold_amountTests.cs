using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class gold_amountTests
    {
        [TestMethod]
        public void gold_amountTest()
        {
            // Arrange
            var expectedValue = "(gold-amount == 10) ;gold_amount";

            // Act
            var testClass = new gold_amount(Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}