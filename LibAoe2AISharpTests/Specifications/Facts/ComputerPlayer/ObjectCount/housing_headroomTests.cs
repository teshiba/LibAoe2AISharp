using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class housing_headroomTests
    {
        [TestMethod]
        public void housing_headroomTest()
        {
            // Arrange
            var expectedValue = "(housing-headroom == 10) ;checks remaining populations capacity";

            // Act
            var testClass = new housing_headroom(Ope.relop.eq, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}