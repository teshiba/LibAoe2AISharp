using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Reflection;
using LibAoe2AISharp.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Specifications.Tests
{
    [TestClass]
    public class DefconstCollectionTests
    {
        [TestMethod]
        public void GetEnumeratorTest()
        {
            // Arrange
            var flag = BindingFlags.NonPublic | BindingFlags.Static;
            typeof(GoalId).GetField("count", flag).SetValue(null, 0);
            typeof(GoalValue).GetField("count", flag).SetValue(null, 0);

            var userdef = new TestDefconstCollection {
                Comment = "UserDefconstCollection comment",
            };
            var actualConstName = new Collection<string>();

            // Act
            foreach (var item in userdef) {
                actualConstName.Add(item.ConstantName);
            }

            // Assert
            Assert.AreEqual("UserDefconstCollection comment", userdef.Comment);
            Assert.AreEqual("TestGoal", actualConstName[0]);
            Assert.AreEqual("TestParamParam1", actualConstName[1]);
            Assert.AreEqual("TestParamParam2", actualConstName[2]);
            Assert.AreEqual("para3ConstName", actualConstName[3]);
        }

        [TestMethod]
        public void GetEnumeratorTestFieldAccessException()
        {
            var instance = new TestDefconstFailCollection();
            _ = Assert.ThrowsException<FieldAccessException>(() =>
            {
                foreach (var item in instance) {
                }
            });
        }

        [TestMethod]
        public void GetEnumeratorTestGetEnumerator()
        {
            // Arrange
            var userdef = new TestDefconstCollection {
                Comment = "UserDefconstCollection comment",
            };

            IEnumerable userdefIEnum = userdef;

            // Act
            Assert.AreEqual(null, userdefIEnum.GetEnumerator());
        }

        [TestMethod]
        public void ContainsTestTrue()
        {
            // Arrange
            var expectedValue = true;

            // Act
            var testClass = new TestDefconstCollection();
            var actualValue = testClass.Contains("Param3");

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void ContainsTestFalse()
        {
            // Arrange
            var expectedValue = false;

            // Act
            var testClass = new TestDefconstFailCollection();
            var actualValue = testClass.Contains("xxxxxx");

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
