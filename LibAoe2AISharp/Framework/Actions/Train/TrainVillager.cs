namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;

    /// <summary>
    /// Train villagers.
    /// </summary>
    public class TrainVillager : Train
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainVillager"/> class.
        /// </summary>
        /// <param name="count">Max count of villagers.</param>
        public TrainVillager(int count)
            : base(unit.villager, count)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainVillager"/> class.
        /// <para>
        /// Until the conditions for researching the given age.
        /// </para>
        /// </summary>
        /// <param name="count">Max count of villagers.</param>
        /// <param name="researchAge">research age.</param>
        public TrainVillager(int count, age researchAge)
            : this(count)
        {
            Comment += " until available next age research.";
            Facts.Add(!new can_research(researchAge + 1));
        }
    }
}
