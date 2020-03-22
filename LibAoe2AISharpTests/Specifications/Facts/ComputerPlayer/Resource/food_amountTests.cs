using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class food_amountTests
    {
        [TestMethod]
        public void food_amountTest()
        {
            // Arrange
            var expectedValue = "(food-amount == 10) ;food_amount";

            // Act
            var testClass = new food_amount(Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}