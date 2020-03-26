using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class commodity_buying_priceTests
    {
        [TestMethod]
        public void commodity_buying_priceTest()
        {
            // Arrange
            var expectedValue = "(commodity-buying-price food == 10)";

            // Act
            var testClass = new commodity_buying_price(commodity.food, Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}