namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestPerFileGenerator : PerFileGenerator
    {
        public override string FileName { get; }

        public override string PathName { get; set; }

        public override string OutputScript => "test output strings";
    }
}