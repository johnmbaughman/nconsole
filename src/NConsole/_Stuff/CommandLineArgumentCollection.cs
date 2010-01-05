using System.Collections.Generic;

namespace NConsole
{
    public class CommandLineArgumentCollection : List<Argument>
    {
        /// <summary>
        /// Gets the argument with the specified name.
        /// </summary>
        /// <param name="name">The name of the argument to get.</param>
        /// <returns></returns>
        public Argument this[string name]
        {
            get
            {
                foreach (Argument argument in this)
                {
                    if (argument.Name == name)
                    {
                        return argument;
                    }
                }
                return null;
            }
        }

        public bool Contains(string name)
        {
            foreach (Argument argument in this)
            {
                if (argument.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}