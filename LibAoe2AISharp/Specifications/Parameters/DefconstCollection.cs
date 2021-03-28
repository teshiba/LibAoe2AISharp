namespace LibAoe2AISharp.Specifications
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using LibAoe2AISharp.Utilty;

    /// <summary>
    /// Collection of defconst command.
    /// <para>
    /// Define the defconst command as a public static readonly field in the inheritance class.
    /// </para>
    /// </summary>
    public abstract class DefconstCollection : IEnumerable<defconst>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefconstCollection"/> class.
        /// </summary>
        protected DefconstCollection()
        {
            foreach (var item in GetType().GetFields()) {
                if (item.GetValue(item) is defconst defconst) {
                    if (defconst.ConstantName == null) {
                        defconst.ConstantName = item.Name;
                        defconst.Comment = item.Name.ToLocalLang();
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets header comment of defconst command group.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        ///  Returns a value indicating whether a specified field occurs within this collection.
        /// </summary>
        /// <param name="fieldName">Field name.</param>
        /// <returns>
        /// true if the Field name parameter occurs within this collection,
        /// or if otherwise, false.
        /// </returns>
        public bool Contains(string fieldName)
        {
            var ret = false;

            foreach (var item in GetType().GetFields()) {
                if (item.GetValue(item) is defconst defconst) {
                    if (item.Name == fieldName) {
                        ret = true;
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// Return fields as defconst collection.
        /// </summary>
        /// <returns>defconst type.</returns>
        public virtual IEnumerator<defconst> GetEnumerator()
        {
            foreach (var item in GetType().GetFields()) {
                switch (item.GetValue(item)) {
                case defconst defconst:
                    yield return defconst;
                    break;
                default:
                    throw new FieldAccessException(item.Name + "is not defconst field");
                }
            }
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
