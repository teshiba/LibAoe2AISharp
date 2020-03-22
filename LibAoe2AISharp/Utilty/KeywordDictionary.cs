using System;
using System.Collections.Generic;

namespace LibAoe2AISharp.Utilty
{
    /// <summary>
    /// Dictionary of AOE2's keyword.
    /// </summary>
    /// <remarks>
    /// This dictionary is not fully translated yet.
    /// </remarks>
    public static class KeywordDictionary
    {
        private static readonly Dictionary<LocalLang, Dictionary<string, string>> DictionaryList
            = new Dictionary<LocalLang, Dictionary<string, string>>() {
                { LocalLang.English, null },
                { LocalLang.Japanese, JapaneseDictionary.List },
                { LocalLang.Non, null },
            };

        private static Dictionary<string, string> dict;

        /// <summary>
        /// Local language type.
        /// </summary>
        public enum LocalLang
        {
            /// <summary>
            /// English
            /// </summary>
            English,

            /// <summary>
            /// Japanese
            /// </summary>
            Japanese,

            /// <summary>
            /// not set dictionary.
            /// </summary>
            Non,
        }

        /// <summary>
        /// Set language.
        /// </summary>
        /// <param name="lang">language.</param>
        public static void SetLocalLang(LocalLang lang)
        {
            var result = DictionaryList.TryGetValue(lang, out dict);

            if (!result) {
                throw new ArgumentOutOfRangeException(nameof(lang));
            }
        }

        /// <summary>
        /// Translate object.ToString() to local language.
        /// </summary>
        /// <param name="word">Object to tranlate.</param>
        /// <returns>local language.</returns>
        public static string ToLocalLang(this object word)
        {
            if (word == null) {
                throw new NullReferenceException();
            }

            string ret = word.ToString();

            if (dict != null) {
                bool result = dict.TryGetValue(ret, out string getString);
                if (result) {
                    ret = getString;
                } else {
                    System.Diagnostics.Debug.Print(";[Info] {0} is undefined word in Dictonary", ret);
                }
            }

            return ret;
        }
    }
}