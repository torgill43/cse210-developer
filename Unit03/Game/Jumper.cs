using System;
using System.Collections.Generic;


namespace Jumper
{
    /// <summary>
    /// <para>The person looking for the Hider.</para>
    /// <para>
    /// The responsibility of a Seeker is to keep track of its location.
    /// </para>
    /// </summary>

    public class Jumper
    {
        private List<string> _jumper = new List<string>();
        public bool _isDead = false;

        /// <summary>
        /// Constructs a new instance of jumper.
        /// </summary>
        public Jumper()
        {
            _jumper.Add(@" ___ ");
            _jumper.Add(@"/___\");
            _jumper.Add(@"\   /");
            _jumper.Add(@" \ / ");
            _jumper.Add(@"  O  ");
            _jumper.Add(@" /|\ ");
            _jumper.Add(@"  | ");
            _jumper.Add(@" / \ ");
        }


        /// <summary>
        /// Displays the jumper
        /// </summary>
        public string ShowJumper()
        {
            string stringJumper = String.Join("\n", _jumper);
            return stringJumper;
        }
        
        /// <summary>
        /// Removes a section of the jumper's parachute.
        /// </summary>
        public void CutLine()
        {
            _jumper.RemoveAt(0);
        }

        /// <summary>
        /// Gets length of jumper.
        /// </summary>
        public int JumperLength()
        {
            return _jumper.Count;
        }

        /// <summary>
        /// This changes the jumper to dead, indicating that the user is out of guesses and game is over.
        /// </summary>
        public void MakeDead()
        {
            _jumper[0] = @"  X  ";
            _isDead = true;
        }

        /// <summary>
        /// This changes shows the winning jumper, indicating that the game is over.
        /// </summary>
        public void MakeWinner()
        {
            _jumper.Clear();
            _jumper.Add(@"  O  ");
            _jumper.Add(@" \|/ ");
            _jumper.Add(@"  |  ");
            _jumper.Add(@" / \ ");
        }
    }
}