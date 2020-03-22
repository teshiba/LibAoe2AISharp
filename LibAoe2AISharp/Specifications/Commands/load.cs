namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Supplys a filename of another script file within your main script file.
    /// </summary>
    public class load : ICommand
    {
        private readonly string fileName;

        /// <summary>
        /// Initializes a new instance of the <see cref="load"/> class.
        /// </summary>
        /// <param name="fileName">the filename does not have path or an extension.</param>
        public load(string fileName)
        {
            Script.AssertContainsNoSpaces(fileName);

            this.fileName = fileName;
        }

        /// <summary>
        /// Gets or Sets comment.
        /// </summary>
        public string Comment { get; set; }

        /// <inheritdoc/>
        public string ToScript(int indentLevel)
        {
            return Script.Tab(indentLevel) + Script.Format("load", Comment, @"""" + fileName + @"""");
        }

        /// <inheritdoc/>
        public string ToScript()
        {
            return ToScript(0);
        }
    }
}
