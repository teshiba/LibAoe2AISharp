using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class AIFactTests
    {
        [TestMethod]
        public void LogicalNotTest()
        {
            // Arrange
            var fact = new TestAIFact();

            // Act
            var notfact = !fact;

            // Assert
            Assert.IsTrue(notfact.IsNot);

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var notFactNull = !((TestAIFact)null);
            });
        }

        [TestMethod]
        public void BitwiseOrTest()
        {
            // Arrange
            var fact1 = new TestAIFact();
            var fact2 = new TestAIFact();

            // Act
            var orCondition = fact1 | fact2;

            // Assert
            Assert.AreEqual(Logical.Or, orCondition.Ope);
            Assert.AreSame(fact1, orCondition.Condition1);
            Assert.AreSame(fact2, orCondition.Condition2);
        }

        [TestMethod]
        public void BitwiseAndTest()
        {
            // Arrange
            var fact1 = new TestAIFact();
            var fact2 = new TestAIFact();

            // Act
            var andCondition = fact1 & fact2;

            // Assert
            Assert.AreEqual(Logical.And, andCondition.Ope);
            Assert.AreSame(fact1, andCondition.Condition1);
            Assert.AreSame(fact2, andCondition.Condition2);
        }

        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var fact = new TestAIFact();
            var notfact = !fact;
            var expectedValue = "(not (TestAIFact testAIFactParam))";

            // Act
            var actualValue = notfact.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}