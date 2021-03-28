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
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.English);
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Japanese);
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Non);

            // Assert
        }

        [TestMethod]
        public void SetLocalLangTestArgumentOutOfRangeException()
        {
            _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Non + 1);
            });
            _ = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.English - 1);
            });
        }

        [TestMethod]
        public void ToLocalLangTest()
        {
            // Arrange
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Japanese);
            string target = "dark_age";

            // Act
            var expectedValue = target.ToLocalLang();

            // Assert
            Assert.AreEqual(expectedValue, "暗黒の時代");

            // After
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Non);
        }

        [TestMethod]
        public void ToLocalLangTestUndefinedKeyword()
        {
            // Arrange
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Japanese);
            string target = "Undefined dummy key word !!!";
            var expectedValue = target;

            // Act
            var actualValue = target.ToLocalLang();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

            // After
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Non);
        }

        [TestMethod]
        public void ToLocalLangTestNonDictionary()
        {
            // Arrange
            LanguageConverter.SetLocalLang(LanguageConverter.LocalLang.Non);
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
            _ = Assert.ThrowsException<ArgumentNullException>(() =>
            {
                _ = target.ToLocalLang();
            });
        }
    }
}