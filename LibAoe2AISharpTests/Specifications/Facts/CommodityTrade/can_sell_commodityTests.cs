using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class can_sell_commodityTests
    {
        [TestMethod]
        public void can_sell_commodityTest()
        {
            // Arrange
            var expectedValue = "(can-sell-commodity food)";

            // Act
            var testClass = new can_sell_commodity(commodity.food);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}