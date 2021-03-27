using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarEatingAllTests
    {
        [TestMethod()]
        public void BoarEatingAllTest()
        {
            // Arrange
            var expVal = ";Boar nothing" + Environment.NewLine +
                         "(defrule" + Environment.NewLine +
                         "    (goal BoarState BoarEating)" + Environment.NewLine +
                         "    (not (dropsite-min-distance live-boar <= 32)) ; Distance 32 le from live-boar" + Environment.NewLine +
                         "    (unit-type-count villager-hunter == 0) ;Check count : unit villager-hunter" + Environment.NewLine +
                         "=>" + Environment.NewLine +
                         "    (set-goal BoarState BoarEnd)" + Environment.NewLine +
                         "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting" + Environment.NewLine +
                         "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters" + Environment.NewLine +
                         ")" + Environment.NewLine;

            // Act
            var testClass = new BoarEatingAll(32);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actualValue);
        }
    }
}