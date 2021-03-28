namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using static LibAoe2AISharp.Framework.BoarHuntingCommandCollection;

    /// <summary>
    /// Initialize boar hunting.
    /// </summary>
    public class BoarInit : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoarInit"/> class.
        /// </summary>
        /// <para>
        /// <see cref="BoarState"/> is set to <see cref="Init"/>.
        /// </para>
        public BoarInit()
        {
            Actions.Add(
                new set_goal(BoarState, Init),
                new disable_self());
        }
    }
}
