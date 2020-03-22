using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class can_buildTests
    {
        [TestMethod]
        public void can_buildTest()
        {
            // Arrange
            var expectedValue = "(can-build archery-range) ;Can build archery_range?";

            // Act
            var testClass = new can_build(building.archery_range);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}