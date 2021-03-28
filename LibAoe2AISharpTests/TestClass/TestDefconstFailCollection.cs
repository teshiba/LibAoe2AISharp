using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Framework.Tests;

namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestDefconstFailCollection : DefconstCollection
    {
        public static readonly GoalId TestGoal = new ("TestGoal", "test goal");
        public static readonly TestParam Param1 = new ("TestParamParam1", "goal para1");
        public static readonly TestParam Param2 = new ("TestParamParam2", "goal para2");
        public static readonly TestParam Param3 = new ("para3ConstName", "goal para3");
        public static readonly string NonDefconstParam = "NonDefconstParamValue";
    }
}