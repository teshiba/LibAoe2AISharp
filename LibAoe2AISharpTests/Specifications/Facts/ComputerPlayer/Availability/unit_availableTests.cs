using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class unit_availableTests
    {
        [TestMethod]
        public void unit_availableTest()
        {
            // Arrange
            var expectedValue = "(unit-available archer)";

            // Act
            var testClass = new unit_available(unit.archer);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}