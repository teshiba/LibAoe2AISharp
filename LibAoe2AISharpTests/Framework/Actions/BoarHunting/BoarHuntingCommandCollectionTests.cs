using System;

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
            var goalId = BoarHuntingCommandCollection.BoarState.Value;

            var expVal =
                ";===============================================================================" + Environment.NewLine +
                ";description: " + Environment.NewLine +
                "; Framework.BoarInit" + Environment.NewLine +
                "; Boar : start hunting" + Environment.NewLine +
                "; BoarLure::distance:12, Hunter：8" + Environment.NewLine +
                "; Boar is exsist" + Environment.NewLine +
                "; Boar is far. Then stop hunting." + Environment.NewLine +
                "; Boar nothing" + Environment.NewLine +
                ";===============================================================================" + Environment.NewLine +
                $"(defconst BoarState {goalId}) ;goal-id[{goalId}] State of boar hunting" + Environment.NewLine +
                "(defconst BoarInit 0) ;goal-id value[0] [Boar]Not hunt yet" + Environment.NewLine +
                "(defconst Boarluring 1) ;goal-id value[1] [Boar]Luring" + Environment.NewLine +
                "(defconst BoarEating 2) ;goal-id value[2] [Boar]Eating" + Environment.NewLine +
                "(defconst BoarEnd 3) ;goal-id value[3] [Boar]End hunting" + Environment.NewLine +
                ";Framework.BoarInit" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (true)" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (set-goal BoarState BoarInit)" + Environment.NewLine +
                "    (disable-self)" + Environment.NewLine +
                ")" + Environment.NewLine +
                "" + Environment.NewLine +
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
                ")" + Environment.NewLine +
                "" + Environment.NewLine +
                ";BoarLure::distance:12, Hunter：8" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (goal BoarState Boarluring)" + Environment.NewLine +
                "    (unit-type-count villager-hunter > 0) ;Check count : unit villager-hunter" + Environment.NewLine +
                "    (dropsite-min-distance live-boar <= 12) ; Distance 12 le from live-boar" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (set-strategic-number sn-maximum-hunt-drop-distance 12) ;maximum_hunt_drop_distance" + Environment.NewLine +
                "    (set-strategic-number sn-minimum-number-hunters 8) ;minimum_number_hunters" + Environment.NewLine +
                "    (set-goal BoarState BoarEating)" + Environment.NewLine +
                ")" + Environment.NewLine +
                "" + Environment.NewLine +
                ";Boar is exsist" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (goal BoarState BoarEating)" + Environment.NewLine +
                "    (not (dropsite-min-distance live-boar <= 12)) ; Distance 12 le from live-boar" + Environment.NewLine +
                "    (dropsite-min-distance live-boar >= 12) ; Distance 12 ge from live-boar" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (set-strategic-number sn-maximum-hunt-drop-distance 32) ;maximum_hunt_drop_distance" + Environment.NewLine +
                "    (set-goal BoarState Boarluring)" + Environment.NewLine +
                ")" + Environment.NewLine +
                "" + Environment.NewLine +
                ";Boar is far. Then stop hunting." + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (goal BoarState BoarEating)" + Environment.NewLine +
                "    (dropsite-min-distance live-boar >= 32) ; Distance 32 ge from live-boar" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (set-goal BoarState BoarEnd)" + Environment.NewLine +
                "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting" + Environment.NewLine +
                "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters" + Environment.NewLine +
                ")" + Environment.NewLine +
                "" + Environment.NewLine +
                ";Boar nothing" + Environment.NewLine +
                "(defrule" + Environment.NewLine +
                "    (goal BoarState BoarEating)" + Environment.NewLine +
                "    (not (dropsite-min-distance live-boar <= 32)) ; Distance 32 le from live-boar" + Environment.NewLine +
                "    (unit-type-count villager-hunter == 0) ;Check count : unit villager-hunter" + Environment.NewLine +
                "=>" + Environment.NewLine +
                "    (set-goal BoarState BoarEnd)" + Environment.NewLine +
                "    (set-strategic-number sn-enable-boar-hunting 1) ;enable_boar_hunting" + Environment.NewLine +
                "    (set-strategic-number sn-minimum-number-hunters 0) ;minimum_number_hunters" + Environment.NewLine +
                ")" + Environment.NewLine +
                "" + Environment.NewLine;

            // Act
            var testClass = new BoarHuntingCommandCollection();
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}