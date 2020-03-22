using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Framework.EachAgesCommandCollection.GroupType;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class EachAgesCommandCollectionTests
    {
        [TestMethod]
        public void EachAgesCommandCollectionTest()
        {
            // Arrange
            var expectedValue = ";===============================================================================\r\n" +
                                ";description: castle_age NotResearching: comment CastleAge\r\n" +
                                ";common fact: [CastleAge]\r\n" +
                                ";===============================================================================\r\n";

            // Act
            var testClass = new EachAgesCommandCollection(CastleAge, "comment CastleAge");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void EachAgesCommandCollectionTestAllAges()
        {
            // Arrange
            var expectedValue = ";===============================================================================\r\n" +
                                ";description: post_imperial_age NotResearching: comment AllAges\r\n" +
                                ";===============================================================================\r\n";

            // Act
            var testClass = new EachAgesCommandCollection(AllAges, "comment AllAges");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void EachAgesCommandCollectionTestWithFinished()
        {
            // Arrange
            var expectedValue = ";===============================================================================\r\n" +
                                ";description: castle_age Finished: comment CastleAge Finished\r\n" +
                                ";common fact: [CastleAgeOnly]\r\n" +
                                ";===============================================================================\r\n";

            // Act
            var testClass = new EachAgesCommandCollection(CastleAge, ResearchState.Finished, "comment CastleAge Finished");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void EachAgesCommandCollectionTestWithNotResearching()
        {
            // Arrange
            var expectedValue = ";===============================================================================\r\n" +
                                ";description: castle_age NotResearching: comment CastleAge NotResearching\r\n" +
                                ";common fact: [CastleAge]\r\n" +
                                ";===============================================================================\r\n";

            // Act
            var testClass = new EachAgesCommandCollection(CastleAge, ResearchState.NotResearching, "comment CastleAge NotResearching");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void EachAgesCommandCollectionTestWithResearching()
        {
            // Arrange
            var expectedValue = ";===============================================================================\r\n" +
                                ";description: imperial_age Researching: comment CastleAge Researching\r\n" +
                                ";common fact: [ToImperialAge]\r\n" +
                                ";===============================================================================\r\n";

            // Act
            var testClass = new EachAgesCommandCollection(CastleAge, ResearchState.Researching, "comment CastleAge Researching");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetCommonFactsTestArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = new EachAgesCommandCollection(CastleAge, ResearchState.Finished - 1, "comment");
            });
        }

        [TestMethod]
        public void GetTransitionstringTestArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = new EachAgesCommandCollection(AllAges, ResearchState.Finished - 1, "comment");
            });
        }
    }
}