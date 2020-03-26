using System.IO;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// Generate .ai file.
    /// </summary>
    public abstract class AIFileGenerator : PerFileGenerator
    {
        /// <summary>
        /// Generate .ai and dependent .per files.
        /// </summary>
        public void OutputFiles()
        {
            // Generate empty .ai file
            using (var sw = new StreamWriter(PathName + @"\" + FileName + ".ai")) {
            }

            // Generate .per file paired with .ai file
            OutputFile();
        }
    }
}
