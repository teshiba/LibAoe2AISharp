using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class BuildMillTests
    {
        [TestMethod]
        public void BuildMillTest()
        {
            // Arrange
            var expectedValue = ";Build mill" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-build mill) ;Can build mill?" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (build mill) ;Build mill" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildMill();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void BuildMillTestCount()
        {
            // Arrange
            var expectedValue = ";Build mill up to 10. Distance more than 10" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-build mill) ;Can build mill?" + Environment.NewLine +
                                "    (building-type-count-total mill < 10) ;Count of mill" + Environment.NewLine +
                                "    (dropsite-min-distance food >= 10) ; Distance 10 ge from food" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (build mill) ;Build mill" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new BuildMill(10) {
                Distance = 10,
            };

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}