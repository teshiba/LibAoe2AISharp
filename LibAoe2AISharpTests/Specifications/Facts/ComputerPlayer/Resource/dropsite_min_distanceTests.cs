using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class dropsite_min_distanceTests
    {
        [TestMethod]
        public void dropsite_min_distanceTest()
        {
            // Arrange
            var expectedValue = "(dropsite-min-distance food == 10) ; Distance 10 eq from food";

            // Act
            var testClass = new dropsite_min_distance(resource_type.food, Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}