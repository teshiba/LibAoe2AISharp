using System;

namespace LibAoe2AISharp.Specifications.Tests
{
    internal class StubActions : CommandCollection<ICommand>
    {
        public override void Add(CommandCollection<ICommand> list, params ICommand[] commands)
        {
            throw new NotImplementedException();
        }

        public override void Add(CommandCollection<ICommand> list)
        {
            throw new NotImplementedException();
        }

        public override void Add(params ICommand[] commands)
        {
            throw new NotImplementedException();
        }

        public override string ToScript()
        {
            return "    test stubActions" + Environment.NewLine;
        }

        public override string ToScript(int indentLevel)
        {
            return "    test stubActions" + Environment.NewLine;
        }
    }
}
