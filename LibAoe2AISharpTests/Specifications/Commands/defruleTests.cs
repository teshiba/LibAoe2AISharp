using System;
using LibAoe2AISharp.Utilty;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class defruleTests
    {
        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            Debug.ChatLocalToSelf = true;
            Debug.ChatToAll = true;
            Debug.DeveloperChatLocalToSelf = true;

            var className = "Specifications.Tests.TestdefruleWithAll";
            var expectedScript = string.Empty;
            expectedScript += ";" + className                                               + Environment.NewLine;
            expectedScript += "(defrule"                                                    + Environment.NewLine;
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
            expectedScript += "=>"                                                          + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action0"           + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action1"           + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action2"           + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action3"           + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action4"           + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action5"           + Environment.NewLine;
            expectedScript += "    (chat-local-to-self \"" + className + "\")"              + Environment.NewLine;
            expectedScript += "    (chat-local-to-self \"[dbg]" + className + "\")"         + Environment.NewLine;
            expectedScript += ")"                                                           + Environment.NewLine;

            var condition = MakeConditions();
            var testRule = new TestdefruleWithAll();
            var list = new TestActionCollection();
            testRule.Actions.Add(list);
            testRule.Facts.Add(condition);

            // Act
            var actualScript = testRule.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
            Assert.AreEqual(className, testRule.Comment);
        }

        [TestMethod]
        [DataRow(false, false, false)]
        [DataRow(false, false, true)]
        [DataRow(false, true, false)]
        [DataRow(false, true, true)]
        [DataRow(true, false, false)]
        [DataRow(true, false, true)]
        [DataRow(true, true, false)]
        [DataRow(true, true, true)]
        public void ToScriptTestActionAndDebugListRule(
            bool chatLocalToSelf,
            bool chatToAll,
            bool developerChatLocalToSelf)
        {
            // Arrange
            Debug.ChatLocalToSelf = chatLocalToSelf;
            Debug.ChatToAll = chatToAll;
            Debug.DeveloperChatLocalToSelf = developerChatLocalToSelf;

            var className = "Specifications.Tests.TestdefruleWithActionAndDebug";
            var expectedScript = string.Empty;
            expectedScript += ";" + className                                       + Environment.NewLine;
            expectedScript += "(defrule"                                            + Environment.NewLine;
            expectedScript += "    test stubFacts"                                  + Environment.NewLine;
            expectedScript += "=>"                                                  + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action0"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action1"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action2"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action3"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action4"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action5"   + Environment.NewLine;

            if (Debug.ChatLocalToSelf) {
                expectedScript += "    (chat-local-to-self \"" + className + "\")" + Environment.NewLine;
            } else if (Debug.ChatToAll) {
                expectedScript += "    (chat-to-all \"" + className + "\")" + Environment.NewLine;
            }

            if (Debug.DeveloperChatLocalToSelf) {
                expectedScript += "    (chat-local-to-self \"[dbg]" + className + "\")" + Environment.NewLine;
            }

            expectedScript += ")" + Environment.NewLine;

            // Act
            var list = new TestActionCollection();
            var testRule = new TestdefruleWithActionAndDebug();
            testRule.Actions.Add(list);
            var actualScript = testRule.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
            Assert.AreEqual(className, testRule.Comment);

            // after
            Debug.ChatLocalToSelf = false;
            Debug.ChatToAll = false;
            Debug.DeveloperChatLocalToSelf = false;
        }

        [TestMethod]
        public void ToScriptTestTestRule()
        {
            // Arrange
            var expectedScript = string.Empty;
            expectedScript += "(defrule"                + Environment.NewLine;
            expectedScript += "    test stubFacts"      + Environment.NewLine;
            expectedScript += "=>"                      + Environment.NewLine;
            expectedScript += "    test stubActions"    + Environment.NewLine;
            expectedScript += "    test debug message"  + Environment.NewLine;
            expectedScript += ")"                       + Environment.NewLine;

            // Act
            var testRule = new Testdefrule {
                Comment = null,
            };
            var actualScript = testRule.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
            Assert.IsNull(testRule.Comment);
        }

        [TestMethod]
        public void ToScriptTestTestActionListRule()
        {
            // Arrange
            var className = "Specifications.Tests.TestdefruleWithAction";
            var expectedScript = string.Empty;
            expectedScript += ";" + className                                       + Environment.NewLine;
            expectedScript += "(defrule"                                            + Environment.NewLine;
            expectedScript += "    test stubFacts"                                  + Environment.NewLine;
            expectedScript += "=>"                                                  + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action0"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action1"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action2"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action3"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action4"   + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action5"   + Environment.NewLine;
            expectedScript += "    test debug message"                              + Environment.NewLine;
            expectedScript += ")"                                                   + Environment.NewLine;

            // Act
            var list = new TestActionCollection();
            var testRule = new TestdefruleWithAction();
            testRule.Actions.Add(list);
            var actualScript = testRule.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
            Assert.AreEqual(className, testRule.Comment);
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
