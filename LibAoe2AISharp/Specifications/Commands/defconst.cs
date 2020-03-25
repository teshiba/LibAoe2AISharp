namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// user-defined constant.
    /// </summary>
    public class defconst : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="defconst"/> class.
        /// <para>
        /// If ConstantName has not been set, that will be set "GetType().Name" by ToScript().
        /// </para>
        /// </summary>
        /// <param name="value">valid integer value.</param>
        public defconst(int value)
            : this(null, value, null)
        {
            Comment = ClassName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="defconst"/> class.
        /// <para>
        /// If ConstantName has not been set, that will be set "GetType().Name" by ToScript().
        /// </para>
        /// </summary>
        /// <param name="value">valid integer value.</param>
        /// <param name="comment">comments at end of line.</param>
        public defconst(int value, string comment)
            : this(null, value, comment)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="defconst"/> class.
        /// </summary>
        /// <param name="constantName">user selected name.</param>
        /// <param name="value">valid integer value.</param>
        public defconst(string constantName, int value)
            : this(constantName, value, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="defconst"/> class.
        /// </summary>
        /// <param name="constantName">user selected constant name.</param>
        /// <param name="value">valid integer value.</param>
        /// <param name="comment">comments at end of line.</param>
        public defconst(string constantName, int value, string comment)
        {
            Script.AssertContainsNoSpaces(constantName);

            Value = value;
            ConstantName = constantName;
            Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="defconst"/> class.
        /// </summary>
        protected defconst()
            : this(null, 0, null)
        {
            Comment = ClassName;
        }

        /// <summary>
        /// Gets or sets user selected name.
        /// </summary>
        public virtual string ConstantName { get; set; }

        /// <summary>
        /// Gets or sets comments at end of line.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets valid integer value.
        /// </summary>
        public int Value { get; protected set; }

        /// <summary>
        /// Gets own class name.
        /// </summary>
        private string ClassName => GetType().Name;

        /// <summary>
        /// Convert to ai script format.
        /// </summary>
        /// <param name="indentLevel">Output indent level.</param>
        /// <returns>ai script.</returns>
        public virtual string ToScript(int indentLevel)
        {
            ConstantName = ConstantName ?? GetType().Name;
            return Script.Tab(indentLevel) + Script.Format("defconst", Comment, ConstantName, Value);
        }

        /// <inheritdoc/>
        public string ToScript()
        {
            return ToScript(0);
        }
    }
}
