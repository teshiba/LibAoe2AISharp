using System;

namespace LibAoe2AISharp.Specifications.Tests
{
    /// <summary>
    /// Unsuport ICondition interface Condition.
    /// </summary>
    internal class UnsuportCondition : ICondition
    {
        public string Comment
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string ToScript()
        {
            throw new NotImplementedException();
        }

        public string ToScript(int indentLevel)
        {
            throw new NotImplementedException();
        }
    }
}