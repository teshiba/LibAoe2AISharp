using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibAoe2AISharp.Utilty.Tests
{
    [TestClass]
    public class KeywordDictionaryTests
    {
        [TestMethod]
        public void SetLocalLangTest()
        {
            // Arrange

            // Act
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.English);
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Japanese);
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Non);

            // Assert
        }

        [TestMethod]
        public void SetLocalLangTestArgumentOutOfRangeException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Non + 1);
            });
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.English - 1);
            });
        }

        [TestMethod]
        public void ToLocalLangTest()
        {
            // Arrange
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Japanese);
            string target = "dark_age";

            // Act
            var expectedValue = target.ToLocalLang();

            // Assert
            Assert.AreEqual(expectedValue, "暗黒の時代");

            // After
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Non);
        }

        [TestMethod]
        public void ToLocalLangTestUndefinedKeyword()
        {
            // Arrange
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Japanese);
            string target = "Undefined dummy key word !!!";
            var expectedValue = target;

            // Act
            var actualValue = target.ToLocalLang();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

            // After
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Non);
        }

        [TestMethod]
        public void ToLocalLangTestNonDictionary()
        {
            // Arrange
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Non);
            string target = "dark_age";

            // Act
            var expectedValue = target.ToLocalLang();

            // Assert
            Assert.AreEqual(expectedValue, "dark_age");
        }

        [TestMethod]
        public void ToLocalLangTestNullReferenceException()
        {
            // Arrange
            string target = null;

            // Assert
            Assert.ThrowsException<NullReferenceException>(() =>
            {
                _ = target.ToLocalLang();
            });
        }
    }
}