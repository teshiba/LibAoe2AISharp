using System;
using LibAoe2AISharp.Utilty;

namespace LibAoe2AISharp.Specifications.Tests
{
    internal class StubDebug : IDebug
    {
        public string ToScript(string className, string message)
        {
            return "    test debug message" + Environment.NewLine;
        }
    }
}
