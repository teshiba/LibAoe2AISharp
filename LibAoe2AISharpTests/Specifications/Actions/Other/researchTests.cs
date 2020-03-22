using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class researchTests
    {
        [TestMethod]
        public void researchTestRi()
        {
            // Arrange
            var expectedValue = "(research ri-bow-saw) ;Research bow_saw";

            // Act
            var testClass = new research(ri.bow_saw);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void researchTestAge()
        {
            // Arrange
            var expectedValue = "(research castle-age) ;Research castle_age";

            // Act
            var testClass = new research(age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void researchTestIsSystemDefinedConst()
        {
            // Arrange
            var expectedValue = "(research my-unique-unit-upgrade) ;Research my_unique_unit_upgrade";

            // Act
            var testClass = new research(ri.my_unique_unit_upgrade);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void researchTestUndefinedResearchIdCollection()
        {
            // Arrange
            var expectedValue = "(research HerbalMedicine) ;Research HerbalMedicine";

            // Act
            var testClass = new research(ri.HerbalMedicine);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}