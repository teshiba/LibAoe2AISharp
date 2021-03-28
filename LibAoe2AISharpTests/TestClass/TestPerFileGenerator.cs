namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestPerFileGenerator : PerFileGenerator
    {
        public override string FileName => "testScript";

        public override string PathName { get; set; }

        public override string OutputScript => "test output strings";
    }
}