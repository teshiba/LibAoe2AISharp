using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class research_completedTests
    {
        [TestMethod]
        public void research_completedTest()
        {
            // Arrange
            var expectedValue = "(research-completed ri-two-man-saw)";

            // Act
            var testClass = new research_completed(ri.two_man_saw);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void research_completedTestIsSystemDefinedConst()
        {
            // Arrange
            var expectedValue = "(research-completed my-unique-unit-upgrade)";

            // Act
            var testClass = new research_completed(ri.my_unique_unit_upgrade);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void research_completedTestUndefinedResearchIdCollection()
        {
            // Arrange
            var expectedValue = "(research-completed HerbalMedicine)";

            // Act
            var testClass = new research_completed(ri.HerbalMedicine);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}