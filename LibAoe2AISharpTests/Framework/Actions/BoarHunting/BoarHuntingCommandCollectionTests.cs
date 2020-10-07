using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass()]
    public class BoarHuntingCommandCollectionTests
    {
        [TestMethod()]
        public void BoarHuntingCommandCollectionTest()
        {
            // Arrange
            var expVal =
                ";===============================================================================\r\n" +
                ";description: \r\n" +
                "; Framework.BoarInit\r\n" +
                "; Boar : start hunting\r\n" +
                "; BoarLure::distance:12, Hunter：8\r\n" +
                "; Boar is exsist\r\n" +
                "; Boar is far. Then stop hunting.\r\n" +
                "; Boar nothing\r\n" +
                ";===============================================================================\r\n" +
                "(defconst BoarState 1) ;goal-id[1] State of boar hunting\r\n" +
                "(defconst BoarInit 0) ;goal-id value[0] [Boar]Not hunt yet\r\n" +
                "(defconst Boarluring 1) ;goal-id value[1] [Boar]Luring\r\n" +
                "(defconst BoarEating 2) ;goal-id value[2] [Boar]Eating\r\n" +
                "(defconst BoarEnd 3) ;goal-id value[3] [Boar]End hunting\r\n" +
                ";Framework.BoarInit\r\n" +
                "(defrule\r\n" +
                "    (true)\r\n" +
                "=>\r\n" +
                "    (set-goal BoarState BoarInit)\r\n" +
                "    (disable-self)\r\n" +
                ")\r\n" +
                "\r\n" +
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
                ")\r\n" +
                "\r\n" +
                ";BoarLure::distance:12, Hunter：8\r\n" +
                "(defrule\r\n" +
                "    (goal BoarState Boarluring)\r\n" +
                "    (unit-type-count villager-hunter > 0) ;Check count : unit villager-hunter\r\n" +
                "    (dropsite-min-distance live-boar <= 12) ; Distance 12 le from live-boar\r\n" +
                "=>\r\n" +
                "    (set-strategic-number sn-maximum-hunt-drop-distance 12) ;maximum_hunt_drop_distance\r\n" +
                "    (set-strategic-number sn-minimum-number-hunters 8) ;minimum_number_hunters\r\n" +
                "    (set-goal BoarState BoarEating)\r\n" +
                ")\r\n" +
                "\r\n" +
                ";Boar is exsist\r\n" +
                "(defrule\r\n" +
                "    (goal BoarState BoarEating)\r\n" +
                "    (not (dropsite-min-distance live-boar <= 12)) ; Distance 12 le from live-boar\r\n" +
                "    (dropsite-min-distance live-boar >= 12) ; Distance 12 ge from live-boar\r\n" +
                "=>\r\n" +
                "    (set-strategic-number sn-maximum-hunt-drop-distance 32) ;maximum_hunt_drop_distance\r\n" +
                "    (set-goal BoarState Boarluring)\r\n" +
                ")\r\n" +
                "\r\n" +
                ";Boar is far. Then stop hunting.\r\n" +
                "(defrule\r\n" +
                "    (goal BoarState BoarEating)\r\n" +
                "    (dropsite-min-distance live-boar >= 32) ; Distance 32 ge from live-boar\r\n" +
                "=>\r\n" +
                "    (set-goal BoarState BoarEnd)\r\n" +
                "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting\r\n" +
                "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters\r\n" +
                ")\r\n" +
                "\r\n" +
                ";Boar nothing\r\n" +
                "(defrule\r\n" +
                "    (goal BoarState BoarEating)\r\n" +
                "    (not (dropsite-min-distance live-boar <= 32)) ; Distance 32 le from live-boar\r\n" +
                "    (unit-type-count villager-hunter == 0) ;Check count : unit villager-hunter\r\n" +
                "=>\r\n" +
                "    (set-goal BoarState BoarEnd)\r\n" +
                "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting\r\n" +
                "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters\r\n" +
                ")\r\n" +
                "\r\n";

            // Act
            var testClass = new BoarHuntingCommandCollection();
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}