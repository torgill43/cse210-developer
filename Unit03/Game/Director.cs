using System;

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
        private string _guess;
        private bool _isPlaying = true;
        private bool _isFound;
        private TerminalService _terminalService = new TerminalService();
        private Jumper _jumper = new Jumper();
        private Word _word = new Word();


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
            _terminalService.WriteText(_word.GetHint());
            Console.WriteLine();
            _terminalService.WriteText(_jumper.ShowJumper());
            Console.WriteLine();
            _terminalService.WriteText("^^^^^^^");
            _guess = _terminalService.ReadText("Guess a letter: ");
            _guess = _guess.ToLower();
            Console.WriteLine();
        }

        /// <summary>
        /// Determines if user guess is correct (update hint) or incorrect (cut line)
        /// </summary>
        private void DoUpdates()
        {
            _isFound = _word.CheckGuess(_guess);
            if (_isFound)
            {
                _word.RevealLetter(_guess);
            }
            else
            {
                _jumper.CutLine();
            }
            int length = _jumper.JumperLength();
            if (length == 4)
            {
                _jumper.MakeDead();
            }
        }

        /// <summary>
        /// Display winning/dead jumper.
        /// </summary>
        private void DoOutputs()
        {
            if (_jumper._isDead)
            {
                _terminalService.WriteText(_jumper.ShowJumper());
                _isPlaying = false;
                Console.WriteLine();
                Console.WriteLine("Sorry, you're out of guesses.");
                Console.WriteLine();

            }
            bool winner = _word.Won();
            if (winner)
            {
                _jumper.MakeWinner();
                _terminalService.WriteText(_jumper.ShowJumper());
                _isPlaying = false;
                Console.WriteLine();
                Console.WriteLine("Woohoo! You guessed the word!");
            }
        }
    }
}