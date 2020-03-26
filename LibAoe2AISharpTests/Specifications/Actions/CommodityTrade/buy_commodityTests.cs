using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class buy_commodityTests
    {
        [TestMethod]
        public void buy_commodityTest()
        {
            // Arrange
            var expectedValue = "(buy-commodity food)";

            // Act
            var testClass = new buy_commodity(commodity.food);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}