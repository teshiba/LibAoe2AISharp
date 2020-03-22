using System;

namespace LibAoe2AISharp.Specifications.Tests
{
    internal class StubFacts : CommandCollection<ICondition>
    {
        public override void Add(CommandCollection<ICondition> list, params ICondition[] commands)
        {
            throw new NotImplementedException();
        }

        public override void Add(CommandCollection<ICondition> list)
        {
            throw new NotImplementedException();
        }

        public override void Add(params ICondition[] commands)
        {
            throw new NotImplementedException();
        }

        public override string ToScript()
        {
            return "    test stubFacts" + Environment.NewLine;
        }

        public override string ToScript(int indentLevel)
        {
            return "    test stubFacts" + Environment.NewLine;
        }
    }
}
