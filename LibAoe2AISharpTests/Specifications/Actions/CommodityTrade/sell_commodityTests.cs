using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class sell_commodityTests
    {
        [TestMethod]
        public void sell_commodityTest()
        {
            // Arrange
            var expectedValue = "(sell-commodity food)";

            // Act
            var testClass = new sell_commodity(commodity.food);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}