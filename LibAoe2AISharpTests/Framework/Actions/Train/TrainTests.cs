using System;

using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class TrainTests
    {
        [TestMethod]
        public void TrainTest()
        {
            // Arrange
            var expectedValue = ";Train archer" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-train archer) ;Can train archer?" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (train archer) ;Train archer" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new Train(unit.archer);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TrainTestCount()
        {
            // Arrange
            var expectedValue = ";Train archer up to 10" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-train archer) ;Can train archer?" + Environment.NewLine +
                                "    (unit-type-count-total archer < 10) ;Check count : unit archer" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (train archer) ;Train archer" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new Train(unit.archer, 10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}