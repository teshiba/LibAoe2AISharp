using System;

namespace LibAoe2AISharp.Specifications.Tests
{
    internal class TestAIFact : AIFact
    {
        public TestAIFact()
        {
        }

        public override string ToScript()
        {
            return ToScript("testAIFactParam");
        }
    }
}