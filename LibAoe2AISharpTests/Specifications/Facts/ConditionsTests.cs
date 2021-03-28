using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class ConditionsTests
    {
        [TestMethod]
        public void ConditionsTestConstantFacts()
        {
            // Act
            var trueFact = new Conditions(true);
            var falseFact = new Conditions(false);

            // Assert
            // true
            Assert.IsNull(trueFact.Condition1);
            Assert.IsNull(trueFact.Condition2);

            // false
            Assert.IsTrue(falseFact.Condition1 is FalseFact);
            Assert.IsNull(falseFact.Condition2);
        }

        [TestMethod]
        public void ConditionsTestICondition1()
        {
            // Arrange
            var testFact = new TestAIFact();

            // Act
            var condition = new Conditions(testFact);

            // Assert
            Assert.AreSame(testFact, condition.Condition1);
            Assert.IsNull(condition.Condition2);
            Assert.AreEqual(Logical.And, condition.Ope);
        }

        [TestMethod]
        public void ConditionsTestICondition2()
        {
            // Arrange
            var testFact1 = new TestAIFact();
            var testFact2 = new TestAIFact();

            // Act
            var condition = new Conditions(testFact1 | testFact2);

            // Assert
            Assert.AreSame(testFact1, condition.Condition1);
            Assert.AreSame(testFact2, condition.Condition2);
            Assert.AreEqual(Logical.Or, condition.Ope);
        }

        [TestMethod]
        public void ConditionsTestICondition3()
        {
            _ = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _ = new Conditions(new UnsuportCondition());
            });
        }

        [TestMethod]
        public void ConditionsTest2ICondition1()
        {
            // Arrange
            var testFact1 = new TestAIFact();
            var testFact2 = new TestAIFact();

            // Act
            var condition = new Conditions(testFact1, testFact2, Logical.Or);

            // Assert
            Assert.AreSame(testFact1, condition.Condition1);
            Assert.AreSame(testFact2, condition.Condition2);
            Assert.AreEqual(Logical.Or, condition.Ope);
        }

        [TestMethod]
        public void ConditionsTest2ICondition2()
        {
            // Arrange
            var testFact = new TestAIFact();

            // Act
            var condition = new Conditions(testFact, null, Logical.Or);

            // Assert
            Assert.AreSame(testFact, condition.Condition1);
            Assert.IsNull(condition.Condition2);
            Assert.AreEqual(Logical.Or, condition.Ope);
        }

        [TestMethod]
        public void ConditionsTest2ICondition3()
        {
            _ = Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _ = new Conditions(null, new TestAIFact(), Logical.Or);
            });
        }

        [TestMethod]
        public void ConditionsTest2ICondition4()
        {
            _ = Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _ = new Conditions(null, null, Logical.Or);
            });
        }

        [TestMethod]
        public void ConditionsTest2ICondition5()
        {
            // Arrange
            var testFact1 = new TestAIFact();
            var testFact2 = new TestAIFact();
            Conditions subCondition = testFact1 & null;

            // Act
            var condition = new Conditions(subCondition, testFact2, Logical.And);

            // Assert
            Assert.AreSame(testFact1, condition.Condition1);
            Assert.AreSame(testFact2, condition.Condition2);
            Assert.AreEqual(Logical.And, condition.Ope);
        }

        [TestMethod]
        public void ConditionsTest2ICondition6()
        {
            // Arrange
            var testFact1 = new TestAIFact();
            var testFact2 = new TestAIFact();
            Conditions subCondition = testFact1 & null;
            Conditions nSubCondition = !subCondition;

            // Act
            var condition = new Conditions(nSubCondition, testFact2, Logical.And);

            // Assert
            Assert.AreSame(nSubCondition, condition.Condition1);
            Assert.AreSame(testFact2, condition.Condition2);
            Assert.AreEqual(Logical.And, condition.Ope);
        }

        [TestMethod]
        public void ConditionsTestInvalidOperand()
        {
            _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = new Conditions(new TestAIFact(), new TestAIFact(), (Logical)(-1));
            });
        }

        [TestMethod]
        public void ToConditionsTest()
        {
            // Arrange
            var fact = new TestAIFact();

            // Act
            Conditions condition = fact;

            // Assert
            Assert.AreSame(fact, condition.Condition1);
        }

        [TestMethod]
        public void BitwiseOrTest()
        {
            // Arrange
            var fact1 = new TestAIFact();
            var fact2 = new TestAIFact();
            var fact3 = new TestAIFact();
            var fact4 = new TestAIFact();
            var falseFact = new FalseFact();

            var trueCondition = new Conditions(true);
            var falseCondition = new Conditions(false);

            var andCondition = new Conditions(fact1, fact2, Logical.And);
            var orCondition = new Conditions(fact3, fact4, Logical.Or);

            // Act
            var orCondtion1 = trueCondition | falseCondition;
            var orCondtion2 = falseCondition | andCondition;
            var orCondtion3 = andCondition | trueCondition;
            var orCondtion4 = andCondition | falseFact;
            var orCondtion5 = andCondition | orCondition;
            var orCondtion6 = null | falseCondition;

            // Assert
            // if (cond1?.Condition1 == null) {
            Assert.AreEqual(null, orCondtion1.Condition1);
            Assert.AreEqual(null, orCondtion1.Condition2);

            // if (cond1 == null) {
            Assert.AreEqual(null, orCondtion6.Condition1);
            Assert.AreEqual(null, orCondtion6.Condition2);

            // } else if (cond1.Condition1 is FalseFact) {
            Assert.AreSame(fact1, orCondtion2.Condition1);
            Assert.AreSame(fact2, orCondtion2.Condition2);

            // if (icond == null) {
            Assert.AreEqual(null, orCondtion3.Condition1);
            Assert.AreEqual(null, orCondtion3.Condition2);

            // } else if (icond is FalseFact) {
            Assert.AreSame(fact1, orCondtion4.Condition1);
            Assert.AreSame(fact2, orCondtion4.Condition2);

            // } else {// other
            Conditions condition51 = (Conditions)orCondtion5.Condition1;
            Conditions condition52 = (Conditions)orCondtion5.Condition2;
            Assert.AreSame(fact1, condition51.Condition1);
            Assert.AreSame(fact2, condition51.Condition2);
            Assert.AreSame(fact3, condition52.Condition1);
            Assert.AreSame(fact4, condition52.Condition2);
            Assert.AreEqual(Logical.Or, orCondtion5.Ope);
            Assert.AreEqual(Logical.And, condition51.Ope);
            Assert.AreEqual(Logical.Or, condition52.Ope);
        }

        [TestMethod]
        public void BitwiseOrTestException()
        {
            _ = Assert.ThrowsException<TypeAccessException>(() =>
            {
                _ = new Conditions(new TestAIFact()) | new UnsuportCondition();
            });
        }

        [TestMethod]
        public void BitwiseAndTest()
        {
            // Arrange
            var fact1 = new TestAIFact();
            var fact2 = new TestAIFact();
            var fact3 = new TestAIFact();
            var fact4 = new TestAIFact();
            var falseFact = new FalseFact();

            var trueCondition = new Conditions(true);
            var falseCondition = new Conditions(false);

            var andCondition = new Conditions(fact1, fact2, Logical.And);
            var orCondition = new Conditions(fact3, fact4, Logical.Or);

            // Act
            var andCondtion1 = trueCondition & andCondition;
            var andCondtion2 = falseCondition & andCondition;
            var andCondtion3 = andCondition & trueCondition;
            var andCondtion4 = andCondition & falseFact;
            var andCondtion5 = andCondition & orCondition;

            var andNullCondtion = null & andCondition;

            // Assert
            // if (cond1?.Condition1 == null) {
            Assert.AreEqual(fact1, andCondtion1.Condition1);
            Assert.AreEqual(fact2, andCondtion1.Condition2);

            // if (cond1 == null) {
            Assert.AreEqual(fact1, andNullCondtion.Condition1);
            Assert.AreEqual(fact2, andNullCondtion.Condition2);

            // } else if (cond1?.Condition1 is FalseFact) {
            Assert.AreSame(falseCondition.Condition1, andCondtion2.Condition1);
            Assert.AreSame(null, andCondtion2.Condition2);

            // if (icond == null) {
            Assert.AreEqual(fact1, andCondtion3.Condition1);
            Assert.AreEqual(fact2, andCondtion3.Condition2);

            // } else if (icond is FalseFact) {
            Assert.AreSame(falseFact, andCondtion4.Condition1);
            Assert.AreSame(null, andCondtion4.Condition2);

            // } else {// other
            Conditions condition51 = (Conditions)andCondtion5.Condition1;
            Conditions condition52 = (Conditions)andCondtion5.Condition2;
            Assert.AreSame(fact1, condition51.Condition1);
            Assert.AreSame(fact2, condition51.Condition2);
            Assert.AreSame(fact3, condition52.Condition1);
            Assert.AreSame(fact4, condition52.Condition2);
            Assert.AreEqual(Logical.And, andCondtion5.Ope);
            Assert.AreEqual(Logical.And, condition51.Ope);
            Assert.AreEqual(Logical.Or, condition52.Ope);
        }

        [TestMethod]
        public void BitwiseAndTestException()
        {
            _ = Assert.ThrowsException<TypeAccessException>(() =>
            {
                _ = new Conditions(new TestAIFact()) & new UnsuportCondition();
            });
        }

        [TestMethod]
        public void LogicalNotTestNullArgument()
        {
            _ = Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _ = Conditions.LogicalNot(null);
            });
        }

        [TestMethod]
        public void LogicalNotTest()
        {
            // Arrange
            var fact1 = new TestAIFact();
            var fact2 = new TestAIFact();
            var fact3 = new TestAIFact();
            var fact4 = new TestAIFact();
            var fact5 = new TestAIFact();
            var fact6 = new TestAIFact();
            var fact7 = new TestAIFact();

            var conditions1 = new Conditions(fact1, null, Logical.And);
            var conditions2 = new Conditions(fact2, null, Logical.Not);
            var conditions3 = new Conditions(fact3, fact4, Logical.And);
            var conditions4 = new Conditions(fact5, fact6, Logical.Or);
            var conditions5 = new Conditions(fact7, null, Logical.Or);

            // Act
            var nCondtion1 = !conditions1;
            var nCondtion2 = !conditions2;
            var nCondtion3 = !conditions3;
            var nCondtion4 = !conditions4;
            var nCondtion5 = !conditions5;

            // Assert
            // or(A,-) -> not(A,-)
            Assert.AreSame(fact7, nCondtion5.Condition1);
            Assert.AreEqual(Logical.Not, nCondtion5.Ope);

            // not(A,B) is Invalid
            _ = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _ = new Conditions(new TestAIFact(), new TestAIFact(), Logical.Not);
            });

            // and(A,-) -> not(A,-)
            Assert.AreSame(fact1, nCondtion1.Condition1);
            Assert.AreEqual(Logical.Not, nCondtion1.Ope);

            // not(A,-) -> and(A,-)
            Assert.AreSame(fact2, nCondtion2.Condition1);
            Assert.AreEqual(Logical.And, nCondtion2.Ope);

            // and(A,B) -> not(and(A,B),-)
            Conditions condition1 = (Conditions)nCondtion3.Condition1;
            Assert.AreSame(fact3, condition1.Condition1);
            Assert.AreSame(fact4, condition1.Condition2);
            Assert.AreEqual(Logical.And, condition1.Ope);
            Assert.AreEqual(Logical.Not, nCondtion3.Ope);

            // or(A,B) -> not( or(A,B),-)
            Conditions condition2 = (Conditions)nCondtion4.Condition1;
            Assert.AreSame(fact5, condition2.Condition1);
            Assert.AreSame(fact6, condition2.Condition2);
            Assert.AreEqual(Logical.Or, condition2.Ope);
            Assert.AreEqual(Logical.Not, nCondtion4.Ope);
        }

        [TestMethod]
        public void ToScriptTestTrueCondition()
        {
            // Arrange
            Conditions cond = MakeConditions() | new Conditions(true);

            var expectedScript = "(true)";

            // Act
            var actualScript = cond.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
        }

        [TestMethod]
        public void ToScriptTestFalseCondition()
        {
            // Arrange
            Conditions cond = MakeConditions() & new Conditions(false);

            var expectedScript = "(false)";

            // Act
            var actualScript = cond.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
        }

        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            Conditions cond = MakeConditions();

            var expectedScript = string.Empty;
            expectedScript += "(and"                                                        + Environment.NewLine;
            expectedScript += "    (or ;condition1 or comment"                              + Environment.NewLine;
            expectedScript += "        (and"                                                + Environment.NewLine;
            expectedScript += "            (TestAIFact testAIFactParam) ;fact1 comment"     + Environment.NewLine;
            expectedScript += "            (TestAIFact testAIFactParam) ;fact2 comment"     + Environment.NewLine;
            expectedScript += "        )"                                                   + Environment.NewLine;
            expectedScript += "        ;no condition2"                                      + Environment.NewLine;
            expectedScript += "        (TestAIFact testAIFactParam) ;fact1 comment"         + Environment.NewLine;
            expectedScript += "    )"                                                       + Environment.NewLine;
            expectedScript += "    (and"                                                    + Environment.NewLine;
            expectedScript += "        (not ;not condition comment"                         + Environment.NewLine;
            expectedScript += "            (TestAIFact testAIFactParam) ;fact1 comment"     + Environment.NewLine;
            expectedScript += "        )"                                                   + Environment.NewLine;
            expectedScript += "        ;notCondition2 comment"                              + Environment.NewLine;
            expectedScript += "        (not (TestAIFact testAIFactParam)) ;fact1 comment"   + Environment.NewLine;
            expectedScript += "    )"                                                       + Environment.NewLine;
            expectedScript += ")";

            // Act
            var actualScript = cond.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
        }

        /// <summary>
        /// make test data for ToScript.
        /// </summary>
        /// <returns>test data conditions.</returns>
        private static Conditions MakeConditions()
        {
            var fact1 = new TestAIFact(){ Comment = "fact1 comment"};
            var fact2 = new TestAIFact(){ Comment = "fact2 comment"};

            var fact3 = new TestAIFact(){ Comment = "fact3 comment"};

            var trueCondition = new Conditions(true);

            var andCondition1 = new Conditions(fact1, fact2, Logical.And);
            var andCondition2 = new Conditions(fact1, null, Logical.And){
                Comment = "no condition2",
            };

            var notCondition1 = new Conditions(fact1, null, Logical.Not) {
                Comment = "not condition comment",
            };

            var notCondition2 = (Conditions)!fact1;
            notCondition2.Comment = "notCondition2 comment";

            var nullCondition1 = new Conditions(trueCondition, null, Logical.Or);

            var condition1 = new Conditions(andCondition1, andCondition2, Logical.Or) {
                Comment = "condition1 or comment",
            };
            var condition2 = new Conditions(notCondition1, notCondition2, Logical.And);
            var condition3 = new Conditions(nullCondition1, fact3, Logical.Or);

            var cond = condition1 & condition2 & condition3;
            return cond;
        }
    }
}