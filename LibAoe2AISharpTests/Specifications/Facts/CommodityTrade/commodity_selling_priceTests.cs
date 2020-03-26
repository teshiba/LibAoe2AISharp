using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class commodity_selling_priceTests
    {
        [TestMethod]
        public void commodity_selling_priceTest()
        {
            // Arrange
            var expectedValue = "(commodity-selling-price food == 10)";

            // Act
            var testClass = new commodity_selling_price(commodity.food, Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}