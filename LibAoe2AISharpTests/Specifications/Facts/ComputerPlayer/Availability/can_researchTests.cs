using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class can_researchTests
    {
        [TestMethod]
        public void can_researchTestresearchItem()
        {
            // Arrange
            var expectedValue = "(can-research ri-ballistics) ;Can research ballistics?";

            // Act
            var testClass = new can_research(ri.ballistics);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void can_researchTestIsSystemDefinedConst()
        {
            // Arrange
            var expectedValue = "(can-research my-unique-unit-upgrade) ;Can research my_unique_unit_upgrade?";

            // Act
            var testClass = new can_research(ri.my_unique_unit_upgrade);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void can_researchTestUndefinedResearchIdCollection()
        {
            // Arrange
            var expectedValue = "(can-research HerbalMedicine) ;Can research HerbalMedicine?";

            // Act
            var testClass = new can_research(ri.HerbalMedicine);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void can_researchTestresearchAge()
        {
            // Arrange
            var expectedValue = "(can-research castle-age) ;Can research castle_age?";

            // Act
            var testClass = new can_research(age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}