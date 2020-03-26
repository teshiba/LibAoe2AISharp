using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class can_buy_commodityTests
    {
        [TestMethod]
        public void can_buy_commodityTest()
        {
            // Arrange
            var expectedValue = "(can-buy-commodity food)";

            // Act
            var testClass = new can_buy_commodity(commodity.food);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}