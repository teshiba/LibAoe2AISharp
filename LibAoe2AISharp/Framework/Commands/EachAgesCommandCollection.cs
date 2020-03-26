using System;
using System.Collections.Generic;
using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Utilty;

using static LibAoe2AISharp.Framework.AgeStateCollection;
using static LibAoe2AISharp.Framework.EachAgesCommandCollection.GroupType;
using static LibAoe2AISharp.Specifications.age;
using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// Define command group that apply to each ages.
    /// </summary>
    public class EachAgesCommandCollection : CommandCollection
    {
        private static readonly Dictionary<GroupType, AgeCondition> ConditionList = new Dictionary<GroupType, AgeCondition>() {
            { AllAges,             new AgeCondition(relop.ne, post_imperial_age) },
            { DarkAge,             new AgeCondition(relop.eq, dark_age) },
            { FeudalAge,           new AgeCondition(relop.eq, feudal_age) },
            { FeudalAgeOrLater,    new AgeCondition(relop.ge, feudal_age) },
            { CastleAge,           new AgeCondition(relop.eq, castle_age) },
            { CastleAgeOrLater,    new AgeCondition(relop.ge, castle_age) },
            { ImperialAge,         new AgeCondition(relop.eq, imperial_age) },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EachAgesCommandCollection"/> class.
        /// </summary>
        /// <param name="type">Group type.</param>
        /// <param name="comment">Comment of the group.</param>
        public EachAgesCommandCollection(GroupType type, string comment)
            : this(type, ResearchState.NotResearching, comment)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EachAgesCommandCollection"/> class.
        /// </summary>
        /// <param name="type">Group type.</param>
        /// <param name="researchState">State of age researching.</param>
        /// <param name="comment">Comment of the group.</param>
        public EachAgesCommandCollection(GroupType type, ResearchState researchState, string comment)
        {
            var ageCondition = ConditionList[type];

            if (ageCondition.Ope != relop.ne) {
                CommonFacts.Add(new current_age(ageCondition.Ope, ageCondition.Age) {
                    Comment = "[" + type.ToString() + "]" + comment,
                });

                SetCommonFacts(type, researchState);
            }

            Comment = GetTransitionstring(researchState, ageCondition.Age) + ": " + comment;
        }

        /// <summary>
        /// Age state definitions.
        /// </summary>
        public enum GroupType
        {
            /// <summary>
            /// All ages
            /// </summary>
            AllAges,

            /// <summary>
            /// Dark age.
            /// </summary>
            DarkAge,

            /// <summary>
            /// Feudal age.
            /// </summary>
            FeudalAge,

            /// <summary>
            /// Castle age.
            /// </summary>
            CastleAge,

            /// <summary>
            /// Imperial age.
            /// </summary>
            ImperialAge,

            /// <summary>
            /// Feudal age or later.
            /// </summary>
            FeudalAgeOrLater,

            /// <summary>
            /// Castle age or later.
            /// </summary>
            CastleAgeOrLater,
        }

        private static string GetTransitionstring(ResearchState researchOption, age targetAge)
        {
            string ret;

            switch (researchOption) {
            case ResearchState.Finished:
                ret = targetAge.ToLocalLang();
                break;
            case ResearchState.Researching:
                ret = (targetAge + 1).ToLocalLang();
                break;
            case ResearchState.NotResearching:
                ret = targetAge.ToLocalLang();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(researchOption));
            }

            return ret + " " + researchOption.ToLocalLang();
        }

        private void SetCommonFacts(GroupType type, ResearchState researchOption)
        {
            switch (researchOption) {
            case ResearchState.Finished:
                CommonFacts.Add(new goal(AgeState, Transitioned) { Comment = researchOption.ToLocalLang() });
                CommonFacts[0].Comment = "[" + type.ToString() + "Only]";
                break;
            case ResearchState.Researching:
                CommonFacts.Add(new goal(AgeState, Transitioning) { Comment = researchOption.ToLocalLang() });
                CommonFacts[0].Comment = "[To" + (type + 1).ToString() + "]";
                break;
            case ResearchState.NotResearching:
                CommonFacts[0].Comment = "[" + type.ToString() + "]";
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(researchOption));
            }
        }

        private struct AgeCondition
        {
            public relop Ope;
            public age Age;

            public AgeCondition(relop ope, age age)
            {
                Ope = ope;
                Age = age;
            }
        }
    }
}