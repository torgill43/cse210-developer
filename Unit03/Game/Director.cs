namespace Jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private string guess;
        private bool _isPlaying = true;
        private TerminalService _terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Display jumper
        /// Prompts the user to guess a letter.
        /// </summary>
        private void GetInputs()
        {
           guess = _terminalService.ReadText("Enter your guess");
        }

        /// <summary>
        /// Determines if user guess is correct (update hint) or incorrect (cut line)
        /// </summary>
        private void DoUpdates()
        {
        }

        /// <summary>
        /// Display winning/dead jumper.
        /// </summary>
        private void DoOutputs()
        {
            // if (_hider.IsFound())
            // {
            //     _isPlaying = false;
            // }

        }
    }
}