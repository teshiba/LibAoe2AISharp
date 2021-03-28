using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class ActionCollectionTests
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var listChild1 = new ActionCollection();
            var listChild2 = new ActionCollection();
            var list = new ActionCollection();
            var actionArray = new Collection<TestAIAction>
            {
                new TestAIAction() { Comment = "action0" },
                new TestAIAction() { Comment = "action1" },
                new TestAIAction() { Comment = "action2" },
                new TestAIAction() { Comment = "action3" },
                new TestAIAction() { Comment = "action4" },
                new TestAIAction() { Comment = "action5" },
            };

            // Act
            listChild1.Add(actionArray[0], actionArray[1]);
            listChild2.Add(actionArray[2], actionArray[3]);
            list.Add(listChild1);
            list.Add(listChild2, actionArray[4], actionArray[5]);

            // Assert
            for (int i = 0; i < actionArray.Count; i++) {
                Assert.AreEqual(list[i], actionArray[i]);
            }

            _ = Assert.ThrowsException<ArgumentNullException>(() =>
            {
                list.Add((ICommand[])null);
            });
        }

        [TestMethod]
        public void ToScriptTest()
        {
            // Arrange
            var expectedScript = string.Empty;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action0" + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action1" + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action2" + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action3" + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action4" + Environment.NewLine;
            expectedScript += "    (TestAIAction testParam1 testParam2) ;action5" + Environment.NewLine;

            // Act
            var list = new TestActionCollection();
            var actualScript = list.ToScript();

            // Assert
            Assert.AreEqual(expectedScript, actualScript);

            _ = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                _ = new ActionCollection().ToScript();
            });
        }
    }
}
