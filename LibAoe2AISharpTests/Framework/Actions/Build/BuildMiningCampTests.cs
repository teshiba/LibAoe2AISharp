using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildMiningCampTests
    {
        [TestMethod]
        public void BuildMiningCampTest()
        {
            // Arrange
            var expectedValue = ";Build mining_camp" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (can-build mining-camp) ;Can build mining-camp?" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (build mining-camp) ;Build mining_camp" + Environment.NewLine +
                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildMiningCamp();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildMiningCampTest1()
        {
            // Arrange
            var expectedValue = ";Build mining_camp up to 10. Distance more than 20" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-build mining-camp) ;Can build mining-camp?" + Environment.NewLine +
                                "    (building-type-count-total mining-camp < 10) ;Count of mining-camp" + Environment.NewLine +
                                "    (or" + Environment.NewLine +
                                "        (dropsite-min-distance gold >= 20) ; Distance 20 ge from gold" + Environment.NewLine +
                                "        (dropsite-min-distance stone >= 20) ; Distance 20 ge from stone" + Environment.NewLine +
                                "    )" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (build mining-camp) ;Build mining_camp" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildMiningCamp(10) {
                Distance = 20,
            };

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}