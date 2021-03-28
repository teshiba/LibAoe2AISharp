namespace LibAoe2AISharp.Specifications.Tests
{
    public class TestActionCollection : ActionCollection
    {
        private readonly ActionCollection listChild1 = new ();
        private readonly ActionCollection listChild2 = new ();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestActionCollection"/> class.
        /// </summary>
        public TestActionCollection()
        {
            listChild1.Add(ActionArray[0], ActionArray[1]);
            listChild2.Add(ActionArray[2], ActionArray[3]);
            Add(listChild1);
            Add(listChild2, ActionArray[4], ActionArray[5]);
        }

        private ActionCollection ActionArray { get; } = new ()
        {
                new TestAIAction() { Comment = "action0" },
                new TestAIAction() { Comment = "action1" },
                new TestAIAction() { Comment = "action2" },
                new TestAIAction() { Comment = "action3" },
                new TestAIAction() { Comment = "action4" },
                new TestAIAction() { Comment = "action5" },
        };
    }
}
