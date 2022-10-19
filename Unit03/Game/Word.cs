using System;
using System.Collections.Generic;


namespace Jumper
{
    /// <summary>
    /// <para>The person hiding from the Seeker.</para>
    /// <para>
    /// The responsibility of Hider is to keep track of its location and distance from the seeker.
    /// </para>
    /// </summary>
    public class Word
    {
        private List<string> _word = new List<string>();
        private List<string> _hint = new List<string>();

        /// <summary>
        /// Constructs a new instance of Hider. 
        /// </summary>
        public Word()
        {
        //    
        }

        /// <summary>
        /// Gets a hint for the seeker.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string DisplayHint()
        {
            
        }

        /// <summary>
        /// Whether or not the hider has been found.
        /// </summary>
        /// <returns>True if found; false if otherwise.</returns>
        public bool RevealLetter()
        {
        }

        /// <summary>
        /// Watches the seeker by keeping track of how far away it is.
        /// </summary>
        /// <param name="seeker">The seeker to watch.</param>
    }
}