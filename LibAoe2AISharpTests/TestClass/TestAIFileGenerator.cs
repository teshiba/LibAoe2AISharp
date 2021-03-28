namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestAIFileGenerator : AIFileGenerator
    {
        public override string FileName => "TestAIFileGenerator";

        public override string PathName { get; set; }

        public override string OutputScript => "test output strings";
    }
}