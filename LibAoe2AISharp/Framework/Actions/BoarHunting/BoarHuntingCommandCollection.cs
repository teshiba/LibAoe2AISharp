using System.Collections.ObjectModel;
using LibAoe2AISharp.Specifications;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Collection of boar hunting commands.
    /// </summary>
    public class BoarHuntingCommandCollection : CommandCollection
    {
        /// <summary>
        /// State of boar hunting.
        /// </summary>
        public static readonly GoalId BoarState = new GoalId("BoarState", "State of boar hunting");

        /// <summary>
        /// Initialize.
        /// </summary>
        public static readonly BoarGoal Init = new BoarGoal("Init", "Not hunt yet");

        /// <summary>
        /// Luring.
        /// </summary>
        public static readonly BoarGoal Luring = new BoarGoal("luring", "Luring");

        /// <summary>
        /// Eating.
        /// </summary>
        public static readonly BoarGoal Eating = new BoarGoal("Eating", "Eating");

        /// <summary>
        /// Finish.
        /// </summary>
        public static readonly BoarGoal Finish = new BoarGoal("End", "End hunting");

        /// <summary>
        /// Initializes a new instance of the <see cref="BoarHuntingCommandCollection"/> class.
        /// </summary>
        public BoarHuntingCommandCollection()
        {
            Add(new Collection<ICommand> {
                BoarState,
                Init,
                Luring,
                Eating,
                Finish,
                new BoarInit(),
                new BoarFindFirst(StartVillagerCount, MaxLureDistance),
                new BoarLure(HuntDistance, HunterCount),
                new BoarReHunting(HuntDistance, MaxLureDistance),
                new BoarFar(MaxLureDistance),
                new BoarEatingAll(MaxLureDistance),
            });
        }

        /// <summary>
        /// Gets or sets villager count of start hunting.
        /// </summary>
        public short StartVillagerCount { get; set; } = 7;

        /// <summary>
        /// Gets or sets max distance for luring boar.
        /// </summary>
        public short MaxLureDistance { get; set; } = 32;

        /// <summary>
        /// Gets or sets villager count for assignment boar hunting.
        /// </summary>
        public short HunterCount { get; set; } = 8;

        /// <summary>
        /// Gets or sets the distance between a boar and a town center for starting hunt at multiple villagers.
        /// </summary>
        public short HuntDistance { get; set; } = 12;
    }
}
