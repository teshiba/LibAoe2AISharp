using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using LibAoe2AISharp.Specifications;

using static LibAoe2AISharp.Specifications.Ope;

namespace LibAoe2AISharp.Framework
{
    /// <summary>
    /// standard AI file.
    /// </summary>
    public abstract class AIFile : PerFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AIFile"/> class.
        /// </summary>
        /// <param name="pathName">output path of AI files.</param>
        /// <param name="author">author of AI files.</param>
        /// <param name="relatedFiles">related files of this file.</param>
        protected AIFile(string pathName, string author, params PerFile[] relatedFiles)
        {
            Author = author;
            PathName = pathName;

            // Add related files.
            foreach (var item in relatedFiles) {
                item.Author ??= author;
                item.ParentFile = this;
                RelatedFiles.Add(item);

                // Force set file path to the path of .ai file
                item.PathName = PathName;
            }
        }

        /// <summary>
        /// Gets related files that will be added by load command.
        /// </summary>
        public Collection<PerFileGenerator> RelatedFiles { get; } = new Collection<PerFileGenerator>();

        /// <summary>
        /// Generate .ai and dependent .per files.
        /// </summary>
        public void OutputFiles()
        {
            // Generate empty .ai file
            using (var sw = new StreamWriter(PathName + @"\" + FileName + ".ai")) {
            }

            // Generate .per file paired with .ai file
            OutputFile();

            // Generate releated files.
            foreach (var item in RelatedFiles) {
                item.OutputFile();
            }
        }

        /// <summary>
        /// Commands of outputting to root AI file.
        /// </summary>
        /// <returns>command groups.</returns>
        protected override CommandGroupCollection GetCommandGroups()
        {
            return new CommandGroupCollection() {
                new CommandCollection("First messages.") {
                    new ShowFirstChatMessage(HeaderComment),
                },
                new CommandCollection("framework defined goal") {
                    new AgeStateCollection(),
                    new InitGoalId(),
                },
                new CommandCollection("System undefined research Ids") {
                    new UndefinedResearchIdCollection(),
                },
                new CommandCollection("System undefined unit Ids") {
                    new UndefinedUnitIdCollection(),
                },
                new CommandCollection("User defined defconsts.") {
                    GetUserDefconst(),
                    new InitUserGoalId(GetGoalIdInitValues()),
                },
                new CommandCollection("Load file") {
                    GetLoadCommand(RelatedFiles),
                },
            };
        }

        /// <summary>
        /// Get user defined defconsts.
        /// </summary>
        /// <returns>collection of defconst collection.</returns>
        protected abstract Collection<DefconstCollection> GetDefconsts();

        /// <summary>
        /// Initial value definitions.
        /// </summary>
        /// <returns>goal id and value.</returns>
        protected abstract Dictionary<GoalId, GoalValue> GetGoalIdInitValues();

        private static Collection<load> GetLoadCommand(Collection<PerFileGenerator> relatedFiles)
        {
            var ret = new Collection<load>();
            foreach (var item in relatedFiles) {
                ret.Add(new load(item.FileName));
            }

            return ret;
        }

        private Collection<defconst> GetUserDefconst()
        {
            var ret = new Collection<defconst>();
            foreach (var defconsts in GetDefconsts()) {
                foreach (var defconst in defconsts) {
                    ret.Add(defconst);
                }
            }

            return ret;
        }

        /// <summary>
        /// Initialize user definition goal-id.
        /// </summary>
        private class InitUserGoalId : defrule
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="InitUserGoalId"/> class.
            /// </summary>
            public InitUserGoalId(Dictionary<GoalId, GoalValue> goal)
            {
                Comment = "Initialize user definition goal-id.";

                foreach (var item in goal) {
                    Actions.Add(new set_goal(item.Key, item.Value));
                }

                Actions.Add(new disable_self());
            }
        }

        /// <summary>
        /// Show first chat message.
        /// </summary>
        private class ShowFirstChatMessage : defrule
        {
            public ShowFirstChatMessage(string message)
            {
                Comment = "Output version infomation.";

                // Delay showing the message.
                Facts.Add(new game_time(relop.ge, 10));

                // Set the message to the chat command each \r\n.
                foreach (var item in message.Replace("\r\n", "\n", StringComparison.Ordinal).Split('\n')) {
                    if (!string.IsNullOrWhiteSpace(item)) {
                        Actions.Add(new chat_local_to_self(item));
                    }
                }

                Actions.Add(new disable_self());
            }
        }
    }
}