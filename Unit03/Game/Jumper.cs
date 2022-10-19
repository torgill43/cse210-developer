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
        private bool _isDead = false;

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
            _jumper.Add(@" / \ ");
        }


        /// <summary>
        /// Displays the jumper
        /// </summary>
        public void ShowJumper(List<string> list)
        {
            TerminalService.DisplayJumper(list);
        }
        /// <summary>
        /// Removes a section of the jumper's parachute
        /// </summary>
        public void CutLine(List<string> list)
        {
            _jumper.RemoveAt(0);
        }


        /// <summary>
        /// This changes the jumper to dead, indicating that the user is out of guesses and game is over.
        /// </summary>
        public bool MakeDead(List<string> list)
        {
            _jumper[0] = @"  X  ";
            _isDead = true;
            return _isDead;
        }
    }
}