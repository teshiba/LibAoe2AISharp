using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarFindFirstTests
    {
        [TestMethod()]
        public void BoarFindFirstTest()
        {
            // Arrange
            var expVal = 
                ";Boar : start hunting" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (goal BoarState BoarInit)" + Environment.NewLine +
                "    (dropsite-min-distance live-boar <= 32) ; Distance 32 le from live-boar" + Environment.NewLine +
                "    (unit-type-count-total villager > 7) ;Check count : unit villager" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (set-strategic-number sn-enable-boar-hunting 2) ;enable_boar_hunting" + Environment.NewLine +
                "    (set-strategic-number sn-minimum-boar-lure-group-size 1) ;minimum_boar_lure_group_size" + Environment.NewLine +
                "    (set-strategic-number sn-maximum-hunt-drop-distance 32) ;maximum_hunt_drop_distance" + Environment.NewLine +
                "    (set-strategic-number sn-minimum-number-hunters 1) ;minimum_number_hunters" + Environment.NewLine +
                "    (set-goal BoarState Boarluring)" + Environment.NewLine +
                ")" + Environment.NewLine;

            // Act
            var testClass = new BoarFindFirst(7, 32);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}