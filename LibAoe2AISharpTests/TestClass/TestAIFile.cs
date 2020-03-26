using System.Collections.Generic;
using System.Collections.ObjectModel;
using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Specifications.Tests;

namespace LibAoe2AISharp.Framework.Tests
{
    internal class TestAIFile : AIFile
    {
        public TestAIFile(string pathName, string author, params PerFile[] relatedFiles)
            : base(pathName, author, relatedFiles)
        {
        }

        protected override Collection<DefconstCollection> GetDefconsts()
        {
            return new Collection<DefconstCollection>() {
                new TestDefconstCollection(),
            };
        }

        protected override Dictionary<GoalId, GoalValue> GetGoalIdInitValues()
        {
            return new Dictionary<GoalId, GoalValue>() {
                {
                    new GoalId("testGoal1", "goal1 comment"),
                    new TestGoalValue("goalVal1", "goalVal1 comment")
                },
            };
        }
    }
}