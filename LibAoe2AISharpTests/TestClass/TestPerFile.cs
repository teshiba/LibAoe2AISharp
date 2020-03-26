using LibAoe2AISharp.Specifications.Tests;

namespace LibAoe2AISharp.Framework.Tests
{
    internal class TestPerFile : PerFile
    {
        protected override CommandGroupCollection GetCommandGroups()
        {
            return new CommandGroupCollection() {
                 new CommandCollection() {
                     new TestDefconstCollection(),
                 },
            };
        }
    }
}