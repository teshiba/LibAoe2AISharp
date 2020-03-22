using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// This fact checks computer player's minimum dropsite walking distance
    /// for a given resource type.
    /// </summary>
    public class dropsite_min_distance : AIFactRelOp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="dropsite_min_distance"/> class.
        /// </summary>
        /// <param name="resource">resource type.</param>
        /// <param name="ope">Relational operator.</param>
        /// <param name="distance">distance between resource and dropsite.</param>
        public dropsite_min_distance(resource_type resource, relop ope, int distance)
            : base(resource, ope, distance)
        {
            Comment = " Distance " + distance + " " + ope.ToLocalLang() + " from " + resource.ToLocalLang();
        }
    }
}