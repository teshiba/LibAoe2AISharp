using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Framework.Tests;

namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestDefconstCollection : DefconstCollection
    {
        public static readonly GoalId TestGoal = new GoalId("TestGoal", "test goal");
        public static readonly TestParam Param1 = new TestParam("TestParamParam1", "goal para1");
        public static readonly TestParam Param2 = new TestParam("TestParamParam2", "goal para2");
        public static readonly TestParam Param3 = new TestParam("para3ConstName", "goal para3");
    }

#pragma warning disable SA1402 // File may only contain a single type
    public class TestDefconstFailCollection : DefconstCollection
#pragma warning restore SA1402 // File may only contain a single type
    {
        public static readonly GoalId TestGoal = new GoalId("TestGoal", "test goal");
        public static readonly TestParam Param1 = new TestParam("TestParamParam1", "goal para1");
        public static readonly TestParam Param2 = new TestParam("TestParamParam2", "goal para2");
        public static readonly TestParam Param3 = new TestParam("para3ConstName", "goal para3");
        public static readonly string NonDefconstParam = "NonDefconstParamValue";
    }
}