using System.IO;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Generate per file.
    /// </summary>
    public abstract class PerFileGenerator
    {
        /// <summary>
        /// Gets file name without extention.
        /// </summary>
        public abstract string FileName { get; }

        /// <summary>
        /// Gets or Sets output path name of .per file.
        /// </summary>
        public abstract string PathName { get; set; }

        /// <summary>
        /// Gets script output to .per file.
        /// </summary>
        public abstract string OutputScript { get; }

        /// <summary>
        /// Output .per file.
        /// </summary>
        public void OutputFile()
        {
            using (var sw = new StreamWriter(PathName + @"\" + FileName + ".per")) {
                sw.Write(OutputScript);
            }
        }
    }
}
