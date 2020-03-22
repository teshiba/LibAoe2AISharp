using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class GathererNumberTests
    {
        [TestMethod]
        public void GathererNumberTest()
        {
            // Arrange

            // Act
            var testClass = new GathererNumber(100, 10, 20, 30, 40);
            var actualValue = testClass;

            // Assert
            Assert.AreEqual(100, actualValue.Total);
            Assert.AreEqual(10, actualValue.Food);
            Assert.AreEqual(20, actualValue.Wood);
            Assert.AreEqual(30, actualValue.Gold);
            Assert.AreEqual(40, actualValue.Stone);
            Assert.AreEqual("count", actualValue.Unit);
            Assert.AreEqual(false, actualValue.UnitPercentage);
        }
    }
}