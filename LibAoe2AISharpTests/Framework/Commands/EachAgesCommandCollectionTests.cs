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
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: castle_age NotResearching: comment CastleAge" + Environment.NewLine +
                                ";common fact: [CastleAge]" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine;

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
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: post_imperial_age NotResearching: comment AllAges" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine;

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
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: castle_age Finished: comment CastleAge Finished" + Environment.NewLine +
                                ";common fact: [CastleAgeOnly]" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine;

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
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: castle_age NotResearching: comment CastleAge NotResearching" + Environment.NewLine +
                                ";common fact: [CastleAge]" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine;

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
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: imperial_age Researching: comment CastleAge Researching" + Environment.NewLine +
                                ";common fact: [ToImperialAge]" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine;

            // Act
            var testClass = new EachAgesCommandCollection(CastleAge, ResearchState.Researching, "comment CastleAge Researching");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void SetCommonFactsTestArgumentOutOfRangeException()
        {
            _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
              {
                  _ = new EachAgesCommandCollection(CastleAge, ResearchState.Finished - 1, "comment");
              });
        }

        [TestMethod]
        public void GetTransitionstringTestArgumentOutOfRangeException()
        {
            _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = new EachAgesCommandCollection(AllAges, ResearchState.Finished - 1, "comment");
            });
        }
    }
}