namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestAIAction : AIAction
    {
        public override string ToScript()
        {
            return ToScript("testParam1", "testParam2");
        }
    }
}