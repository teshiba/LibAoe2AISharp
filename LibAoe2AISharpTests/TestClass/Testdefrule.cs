namespace LibAoe2AISharp.Specifications.Tests
{
    internal class Testdefrule : defrule
    {
        public Testdefrule()
            : base(new StubFacts(), new StubActions(), new StubDebug())
        {
        }
    }
}
