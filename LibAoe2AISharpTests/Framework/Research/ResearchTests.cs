using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class ResearchTests
    {
        [TestMethod]
        public void ResearchTestResearchAge()
        {
            // Arrange
            var expectedValue = ";Research castle_age\r\n" +
                                "(defrule\r\n" +
                                "    (can-research castle-age) ;Can research castle-age?\r\n" +
                                "=>\r\n" +
                                "    (research castle-age) ;Research castle_age\r\n" +
                                ")\r\n";

            // Act
            var testClass = new Research(age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ResearchTestReaearchItem()
        {
            // Arrange
            var expectedValue = ";Research cavalier\r\n" +
                                "(defrule\r\n" +
                                "    (can-research ri-cavalier) ;Can research cavalier?\r\n" +
                                "=>\r\n" +
                                "    (research ri-cavalier) ;Research cavalier\r\n" +
                                ")\r\n";

            // Act
            var testClass = new Research(ri.cavalier);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ResearchTestReaearchItemUnitCount()
        {
            // Arrange
            var expectedValue = ";Research fletching :archer up to 10\r\n" +
                                "(defrule\r\n" +
                                "    (can-research ri-fletching) ;Can research fletching?\r\n" +
                                "    (unit-type-count-total archer >= 10) ;Check count : unit archer\r\n" +
                                "=>\r\n" +
                                "    (research ri-fletching) ;Research fletching\r\n" +
                                ")\r\n";

            // Act
            var testClass = new Research(ri.fletching, unit.archer, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}