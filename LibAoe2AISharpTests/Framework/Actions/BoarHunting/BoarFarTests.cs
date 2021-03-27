using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarFarTests
    {
        [TestMethod()]
        public void BoarFarTest()
        {
            // Arrange
            var expVal =
                ";Boar is far. Then stop hunting." + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (goal BoarState BoarEating)" + Environment.NewLine +
                "    (dropsite-min-distance live-boar >= 30) ; Distance 30 ge from live-boar" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (set-goal BoarState BoarEnd)" + Environment.NewLine +
                "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting" + Environment.NewLine +
                "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters" + Environment.NewLine +
                ")" + Environment.NewLine;

            // Act
            var testClass = new BoarFar(30);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}