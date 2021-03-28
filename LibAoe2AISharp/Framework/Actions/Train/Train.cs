namespace LibAoe2AISharp.Framework
{
    using LibAoe2AISharp.Specifications;
    using LibAoe2AISharp.Utilty;
    using static LibAoe2AISharp.Specifications.Ope;

    /// <summary>
    /// Basic control of train action.
    /// Confirm that the unit can be training and train the unit.
    /// </summary>
    public class Train : defrule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Train"/> class.
        /// </summary>
        /// <param name="trainingUnit">unit type of training.</param>
        public Train(unit trainingUnit)
        {
            Comment = "Train " + trainingUnit.ToLocalLang();
            Facts.Add(new can_train(trainingUnit));
            Actions.Add(new train(trainingUnit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Train"/> class.
        /// Train unit until Max count.
        /// </summary>
        /// <param name="trainingUnit">unit type of training.</param>
        /// <param name="count">Max count of unit.</param>
        public Train(unit trainingUnit, int count)
            : this(trainingUnit)
        {
            Comment += $" up to {count}";
            Facts.Add(new unit_type_count_total(trainingUnit, relop.lt, count));
        }
    }
}
