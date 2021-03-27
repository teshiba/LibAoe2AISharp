using System;
using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Specifications.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework.Tests
{
    [TestClass]
    public class CommandCollectionTests
    {
        [TestMethod]
        public void CommandCollectionTest()
        {
            // Arrange
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: " + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine;

            // Act
            var testClass = new CommandCollection();
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CommandCollectionTestComment()
        {
            // Arrange
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: CommandCollection comment" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine;

            // Act
            var testClass = new CommandCollection("CommandCollection comment");
            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CommandCollectionTestToScript()
        {
            // Arrange
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: " + Environment.NewLine +
                                ";common fact: [dark_age]" + Environment.NewLine +
                                "; [dark_age]: Build archery_range" + Environment.NewLine +
                                "; [dark_age]: Build blacksmith" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine +
                                ";[dark_age]: Build archery_range" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-build archery-range) ;Can build archery-range?" + Environment.NewLine +
                                "    (current-age == dark-age) ;[dark-age]" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (build archery-range) ;Build archery_range" + Environment.NewLine +
                                ")" + Environment.NewLine + Environment.NewLine +
                                ";[dark_age]: Build blacksmith" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-build blacksmith) ;Can build blacksmith?" + Environment.NewLine +
                                "    (current-age == dark-age) ;[dark-age]" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (build blacksmith) ;Build blacksmith" + Environment.NewLine +
                                ")" + Environment.NewLine +
                                "" + Environment.NewLine;

            // Act
            var testClass = new CommandCollection() {
                new Build(building.archery_range),
                new Build(building.blacksmith),
            };

            testClass.CommonFacts.Add(
                new current_age(relop.eq, age.dark_age) {
                    Comment = "[" + age.dark_age.ToString() + "]",
                });

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        
        [TestMethod]
        public void CommandCollectionTestToScriptWithDefconst()
        {
            // Arrange
            var expectedValue = ";===============================================================================" + Environment.NewLine +
                                ";description: " + Environment.NewLine +
                                ";common fact: [dark_age]" + Environment.NewLine +
                                "; [dark_age]: Build archery_range" + Environment.NewLine +
                                ";===============================================================================" + Environment.NewLine +
                                ";[dark_age]: Build archery_range" + Environment.NewLine +
                                "(defrule" + Environment.NewLine +
                                "    (can-build archery-range) ;Can build archery-range?" + Environment.NewLine +
                                "    (current-age == dark-age) ;[dark-age]" + Environment.NewLine +
                                "=>" + Environment.NewLine +
                                "    (build archery-range) ;Build archery_range" + Environment.NewLine +
                                ")" + Environment.NewLine +
                                "" + Environment.NewLine +
                                "(defconst defconst 0) ;defconst" + Environment.NewLine;

            // Act
            var testClass = new CommandCollection() {
                new Build(building.archery_range),
                new defconst(0),
            };

            testClass.CommonFacts.Add(
                new current_age(relop.eq, age.dark_age) {
                    Comment = "[" + age.dark_age.ToString() + "]",
                });

            var actualValue = testClass.ToScript();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void CommandCollectionTestNullReferenceException()
        {
            // Arrange
            var testClass = new CommandCollection() {
                new Build(building.archery_range),
            };

            // Act
            testClass[0] = null;

            // Assert
            Assert.ThrowsException<NullReferenceException>(() =>
            {
                _ = testClass.ToScript();
            });
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange

            // Act
            var testClass = new CommandCollection {
                new TestDefconstCollection(),
            };

            // Assert
            Assert.AreEqual(TestDefconstCollection.TestGoal, testClass[0]);
            Assert.AreEqual(TestDefconstCollection.Param1, testClass[1]);
            Assert.AreEqual(TestDefconstCollection.Param2, testClass[2]);
            Assert.AreEqual(TestDefconstCollection.Param3, testClass[3]);
        }

        [TestMethod]
        public void AddTestNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var testClass = new CommandCollection("CommandCollection comment") {
                    null,
                };
            });
        }
    }
}