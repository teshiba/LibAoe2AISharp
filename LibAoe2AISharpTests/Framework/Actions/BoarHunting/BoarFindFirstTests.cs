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
                ";Boar : start hunting\r\n" +
                "(defrule\r\n" +
                "    (goal BoarState BoarInit)\r\n" +
                "    (dropsite-min-distance live-boar <= 32) ; Distance 32 le from live-boar\r\n" +
                "    (unit-type-count-total villager > 7) ;Check count : unit villager\r\n" +
                "=>\r\n" +
                "    (set-strategic-number sn-enable-boar-hunting 2) ;enable_boar_hunting\r\n" +
                "    (set-strategic-number sn-minimum-boar-lure-group-size 1) ;minimum_boar_lure_group_size\r\n" +
                "    (set-strategic-number sn-maximum-hunt-drop-distance 32) ;maximum_hunt_drop_distance\r\n" +
                "    (set-strategic-number sn-minimum-number-hunters 1) ;minimum_number_hunters\r\n" +
                "    (set-goal BoarState Boarluring)\r\n" +
                ")\r\n";

            // Act
            var testClass = new BoarFindFirst(7, 32);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}