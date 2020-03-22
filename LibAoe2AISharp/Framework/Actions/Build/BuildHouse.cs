using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Building house.
    /// </summary>
    public class BuildHouse : Build
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildHouse"/> class.
        /// </summary>
        public BuildHouse()
            : base(building.house)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildHouse"/> class.
        /// </summary>
        /// <param name="remain">remaining capacity of populations.</param>
        public BuildHouse(int remain)
            : base(building.house)
        {
            Comment += $" remaining capacity less than {remain}";
            Facts.Add(new housing_headroom(relop.le, remain));
        }
    }
}
