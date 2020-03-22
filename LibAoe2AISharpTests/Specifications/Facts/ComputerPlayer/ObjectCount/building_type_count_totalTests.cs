using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class building_type_count_totalTests
    {
        [TestMethod]
        public void building_type_count_totalTest()
        {
            // Arrange
            var expectedValue = "(building-type-count-total archery-range == 10) ;Count of archery_range";

            // Act
            var testClass = new building_type_count_total(
                            building.archery_range, Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}