using System;
using System.Collections.ObjectModel;

namespace LibAoe2AISharp.Specifications
{
    /// <summary>
    /// command collection abstruct class.
    /// </summary>
    /// <typeparam name="T">collection member type.</typeparam>
    public abstract class CommandCollection<T> : Collection<T>, ICommand
    {
        /// <summary>
        /// Gets or sets comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Adds collection and commands to the end of the Collections.
        /// </summary>
        /// <param name="list">another CommandCollection.</param>
        /// <param name="commands">Array of commands.</param>
        public abstract void Add(CommandCollection<T> list, params T[] commands);

        /// <summary>
        /// Adds collection to the end of the Collections.
        /// </summary>
        /// <param name="list">another CommandCollection.</param>
        public abstract void Add(CommandCollection<T> list);

        /// <summary>
        /// Adds commands to the end of the Collections.
        /// </summary>
        /// <param name="commands">Array of commands.</param>
        public abstract void Add(params T[] commands);

        /// <summary>
        /// Adds an <typeparamref name="T"/> object to the end of the collection.
        /// </summary>
        /// <param name="command">command.</param>
        public new virtual void Add(T command)
        {
            if (command == null) {
                throw new ArgumentNullException(nameof(command));
            }

            base.Add(command);
        }

        /// <inheritdoc/>
        public abstract string ToScript();

        /// <inheritdoc/>
        public abstract string ToScript(int indentLevel);
    }
}