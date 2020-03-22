using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class research_availableTests
    {
        [TestMethod]
        public void research_availableTestResearchAge()
        {
            // Arrange
            var expectedValue = "(research-available castle-age) ;castle_age is available.";

            // Act
            var testClass = new research_available(age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void research_availableTestResearchItem()
        {
            // Arrange
            var expectedValue = "(research-available ri-ballistics) ;ballistics is available.";

            // Act
            var testClass = new research_available(ri.ballistics);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void research_availableTestResearchItemIsSystemDefinedConst()
        {
            // Arrange
            var expectedValue = "(research-available my-unique-unit-upgrade) ;my_unique_unit_upgrade is available.";

            // Act
            var testClass = new research_available(ri.my_unique_unit_upgrade);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void research_availableTestUndefinedResearchIdCollection()
        {
            // Arrange
            var expectedValue = "(research-available HerbalMedicine) ;HerbalMedicine is available.";

            // Act
            var testClass = new research_available(ri.HerbalMedicine);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}