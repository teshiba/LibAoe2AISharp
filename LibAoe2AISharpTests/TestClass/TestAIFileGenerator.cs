namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestAIFileGenerator : AIFileGenerator
    {
        public override string FileName
        {
            get { return GetType().Name; }
        }

        public override string PathName { get; set; }

        public override string OutputScript => "test output strings";
    }
}