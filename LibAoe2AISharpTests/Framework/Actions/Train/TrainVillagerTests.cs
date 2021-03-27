using System;

using LibAoe2AISharp.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class TrainVillagerTests
    {
        [TestMethod]
        public void TrainVillagerTest()
        {
            // Arrange
            var expectedValue = ";Train villager up to 10" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-train villager) ;Can train villager?" + Environment.NewLine +
                                "    (unit-type-count-total villager < 10) ;Check count : unit villager" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (train villager) ;Train villager" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new TrainVillager(10);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TrainVillagerTestAge()
        {
            // Arrange
            var expectedValue = ";Train villager up to 10 until available next age research." + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-train villager) ;Can train villager?" + Environment.NewLine +
                                "    (unit-type-count-total villager < 10) ;Check count : unit villager" + Environment.NewLine +
                                "    (not (can-research imperial-age)) ;Can research imperial-age?" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (train villager) ;Train villager" + Environment.NewLine +
                                ")" + Environment.NewLine;

            // Act
            var testClass = new TrainVillager(10, age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}