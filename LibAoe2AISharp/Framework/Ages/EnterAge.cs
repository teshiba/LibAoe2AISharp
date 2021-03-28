namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Framework.AgeStateCollection;

    /// <summary>
    /// Basic control after reserching the age.
    /// </summary>
    public abstract class EnterAge : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnterAge"/> class.
        /// </summary>
        protected EnterAge()
        {
            Actions.Add(
                new set_goal(AgeState, Transitioned),
                new disable_self());
        }
    }
}