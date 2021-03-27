using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarReHuntingTests
    {
        [TestMethod()]
        public void BoarReHuntingTest()
        {
            // Arrange
            var expVal = 
                ";Boar is exsist" + Environment.NewLine + 
                "(defrule" + Environment.NewLine + 
                "    (goal BoarState BoarEating)" + Environment.NewLine + 
                "    (not (dropsite-min-distance live-boar <= 12)) ; Distance 12 le from live-boar" + Environment.NewLine + 
                "    (dropsite-min-distance live-boar >= 12) ; Distance 12 ge from live-boar" + Environment.NewLine + 
                "=>" + Environment.NewLine + 
                "    (set-strategic-number sn-maximum-hunt-drop-distance 32) ;maximum_hunt_drop_distance" + Environment.NewLine + 
                "    (set-goal BoarState Boarluring)" + Environment.NewLine + 
                ")" + Environment.NewLine;

            // Act
            var testClass = new BoarReHunting(12, 32);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}