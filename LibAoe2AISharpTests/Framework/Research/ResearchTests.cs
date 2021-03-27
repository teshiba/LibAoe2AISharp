using System;

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
            var expectedValue = ";Research castle_age" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-research castle-age) ;Can research castle-age?" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (research castle-age) ;Research castle_age" + Environment.NewLine +
                                ")" + Environment.NewLine;

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
            var expectedValue = ";Research cavalier" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-research ri-cavalier) ;Can research cavalier?" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (research ri-cavalier) ;Research cavalier" + Environment.NewLine +
                                ")" + Environment.NewLine;

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
            var expectedValue = ";Research fletching :archer up to 10" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-research ri-fletching) ;Can research fletching?" + Environment.NewLine +
                                "    (unit-type-count-total archer >= 10) ;Check count : unit archer" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (research ri-fletching) ;Research fletching" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new Research(ri.fletching, unit.archer, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}