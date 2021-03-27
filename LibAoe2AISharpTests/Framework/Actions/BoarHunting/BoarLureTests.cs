using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarLureTests
    {
        [TestMethod()]
        public void BoarLureTest()
        {
            // Arrange
            var expVal = 
                ";BoarLure::distance:12, Hunter：8" + Environment.NewLine + 
                "(defrule" + Environment.NewLine + 
                "    (goal BoarState Boarluring)" + Environment.NewLine + 
                "    (unit-type-count villager-hunter > 0) ;Check count : unit villager-hunter" + Environment.NewLine + 
                "    (dropsite-min-distance live-boar <= 12) ; Distance 12 le from live-boar" + Environment.NewLine + 
                "=>" + Environment.NewLine + 
                "    (set-strategic-number sn-maximum-hunt-drop-distance 12) ;maximum_hunt_drop_distance" + Environment.NewLine + 
                "    (set-strategic-number sn-minimum-number-hunters 8) ;minimum_number_hunters" + Environment.NewLine + 
                "    (set-goal BoarState BoarEating)" + Environment.NewLine + 
                ")" + Environment.NewLine;

            // Act
            var testClass = new BoarLure(12, 8);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}