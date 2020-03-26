using LibAoe2AISharp.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class wall_completed_percentageTests
    {
        [TestMethod]
        public void wall_completed_percentageTest()
        {
            // Arrange
            var expectedValue = "(wall-completed-percentage 2 == 20)";

            // Act
            var testClass = new wall_completed_percentage(Perimeter.Far, relop.eq, 20);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}