using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class FactCollectionTests
    {
        [TestMethod]
        public void AddTestAIFact()
        {
            // Arrange
            var listChild1 = new FactCollection();
            var listChild2 = new FactCollection();
            var list = new FactCollection();
            var factArray = new Collection<TestAIFact>
            {
                new TestAIFact() { Comment = "fact0" },
                new TestAIFact() { Comment = "fact1" },
                new TestAIFact() { Comment = "fact2" },
                new TestAIFact() { Comment = "fact3" },
                new TestAIFact() { Comment = "fact4" },
                new TestAIFact() { Comment = "fact5" },
            };

            // Act
            listChild1.Add(factArray[0], factArray[1]);
            listChild2.Add(factArray[2], factArray[3]);
            list.Add(listChild1);
            list.Add(listChild2, factArray[4], factArray[5]);

            // Assert
            for (int i = 0; i < factArray.Count; i++) {
                Assert.AreEqual(list[i], factArray[i]);
            }
        }

        [TestMethod]
        public void AddTestAndConditions()
        {
            // Arrange
            var facts = new FactCollection();
            var fact1 = new TestAIFact { Comment = "fact1 comment"};
            var fact2 = new TestAIFact { Comment = "fact2 comment"};
            var fact3 = new TestAIFact { Comment = "fact3 comment"};
            var cond = new Conditions(fact3);

            // Act
            var andCondition = fact1 & fact2;
            facts.Add(andCondition);
            facts.Add(cond);

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                facts.Add((Conditions[])null);
            });

            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                facts.Add((Conditions)null);
            });

            // Assert
            Assert.AreSame(fact1, facts[0]);
            Assert.AreSame(fact2, facts[1]);
            Assert.AreSame(fact3, facts[2]);
            Assert.AreEqual(3, facts.Count);
        }

        [TestMethod]
        public void AddTestOrConditions()
        {
            // Arrange
            var facts = new FactCollection();
            var fact1 = new TestAIFact { Comment = "fact1 comment"};
            var fact2 = new TestAIFact { Comment = "fact2 comment"};
            var fact3 = new TestAIFact { Comment = "fact3 comment"};
            var cond = new Conditions(fact3);

            // Act
            var orCondition = fact1 | fact2;
            facts.Add(orCondition);
            facts.Add(cond);
            var cond0 = facts[0] as Conditions;

            // Assert
            Assert.AreSame(fact1, cond0.Condition1);
            Assert.AreSame(fact2, cond0.Condition2);
            Assert.AreSame(fact3, facts[1]);
            Assert.AreSame(orCondition, facts[0]);
            Assert.AreEqual(2, facts.Count);
        }

        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var listChild1 = new FactCollection();
            var listChild2 = new FactCollection();
            var list = new FactCollection();
            var factArray = new Collection<TestAIFact>
            {
                new TestAIFact() { Comment = "fact0" },
                new TestAIFact() { Comment = "fact1" },
                new TestAIFact() { Comment = "fact2" },
                new TestAIFact() { Comment = "fact3" },
                new TestAIFact() { Comment = "fact4" },
                new TestAIFact() { Comment = "fact5" },
            };
            listChild1.Add(factArray[0], factArray[1]);
            listChild2.Add(factArray[2], factArray[3]);
            list.Add(listChild1);
            list.Add(listChild2, factArray[4], factArray[5]);

            var expectedScript =
                  "(TestAIFact testAIFactParam) ;fact0" + Environment.NewLine
                + "(TestAIFact testAIFactParam) ;fact1" + Environment.NewLine
                + "(TestAIFact testAIFactParam) ;fact2" + Environment.NewLine
                + "(TestAIFact testAIFactParam) ;fact3" + Environment.NewLine
                + "(TestAIFact testAIFactParam) ;fact4" + Environment.NewLine
                + "(TestAIFact testAIFactParam) ;fact5" + Environment.NewLine
                ;

            // Act
            var actualScript = list.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
        }

        [TestMethod]
        public void ToScriptTestNoItem()
        {
            // Arrange
            var list = new FactCollection();

            var expectedScript = "(true)" + Environment.NewLine;

            // Act
            var actualScript = list.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);
        }
    }
}