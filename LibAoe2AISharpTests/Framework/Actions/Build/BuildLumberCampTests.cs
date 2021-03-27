using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildLumberCampTests
    {
        [TestMethod]
        public void BuildLumberCampTest()
        {
            // Arrange
            var expectedValue = ";Build lumber_camp Distance more than 10" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-build lumber-camp) ;Can build lumber-camp?" + Environment.NewLine +
                                "    (dropsite-min-distance wood >= 10) ; Distance 10 ge from wood" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (build lumber-camp) ;Build lumber_camp" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildLumberCamp {
                Distance = 10,
            };
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildLumberCampTest1()
        {
            // Arrange
            var expectedValue = ";Build lumber_camp up to 10." + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (can-build lumber-camp) ;Can build lumber-camp?" + Environment.NewLine +
                "    (building-type-count-total lumber-camp < 10) ;Count of lumber-camp" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (build lumber-camp) ;Build lumber_camp" + Environment.NewLine +
                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildLumberCamp(10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}