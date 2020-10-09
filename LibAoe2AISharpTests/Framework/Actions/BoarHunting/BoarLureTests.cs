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
                ";BoarLure::distance:12, Hunter：8\r\n" + 
                "(defrule\r\n" + 
                "    (goal BoarState Boarluring)\r\n" + 
                "    (unit-type-count villager-hunter > 0) ;Check count : unit villager-hunter\r\n" + 
                "    (dropsite-min-distance live-boar <= 12) ; Distance 12 le from live-boar\r\n" + 
                "=>\r\n" + 
                "    (set-strategic-number sn-maximum-hunt-drop-distance 12) ;maximum_hunt_drop_distance\r\n" + 
                "    (set-strategic-number sn-minimum-number-hunters 8) ;minimum_number_hunters\r\n" + 
                "    (set-goal BoarState BoarEating)\r\n" + 
                ")\r\n";

            // Act
            var testClass = new BoarLure(12, 8);
            var actVal = testClass.ToScript();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }
    }
}