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
            var expectedValue = ";Train villager up to 10\r\n" +
                                "(defrule\r\n" +
                                "    (can-train villager) ;Can train villager?\r\n" +
                                "    (unit-type-count-total villager < 10) ;Check count : unit villager\r\n" +
                                "=>\r\n" +
                                "    (train villager) ;Train villager\r\n" +
                                ")\r\n";

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
            var expectedValue = ";Train villager up to 10 until available next age research.\r\n" +
                                "(defrule\r\n" +
                                "    (can-train villager) ;Can train villager?\r\n" +
                                "    (unit-type-count-total villager < 10) ;Check count : unit villager\r\n" +
                                "    (not (can-research imperial-age)) ;Can research imperial-age?\r\n" +
                                "=>\r\n" +
                                "    (train villager) ;Train villager\r\n" +
                                ")\r\n";

            // Act
            var testClass = new TrainVillager(10, age.castle_age);
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}