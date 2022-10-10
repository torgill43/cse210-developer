using System;
using System.Collections.Generic;


namespace HiLo.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        Deck _card;
        int currentCard;
        int nextCard;
        string userGuess;
        string playAgain;
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 300;

        /// <summary>
        /// Constructs a new instance of Director. 
        /// </summary>
        public Director()
        {
            Deck card = new Deck();
            currentCard = card._cardValue;
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
                PlayAgain();
            }
        }

        /// <summary>
        /// Shows the value of the current card. 
        /// Prompts the user to guess higher or lower.
        /// </summary>
        public void GetInputs()
        {
            Console.WriteLine($"The current card is: {currentCard}");
            Console.Write("Guess higher or lower [h/l]: ");
            userGuess = Console.ReadLine();


        }

        /// <summary>
        /// Draws a new card.
        /// Compares current and new card.
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            Deck card = new Deck();
            nextCard = card._cardValue;
            Console.WriteLine($"The new card is: {nextCard}");

            _score = 0;

            _score += (currentCard == nextCard) ? 0 : ((userGuess == "h") == (currentCard < nextCard)) ? 100 : -75;

            _totalScore += _score;

            currentCard = nextCard;
        }

        ///<summary>
        /// Askes the user if they want to play again.
        ///</summary>
        public void PlayAgain()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.Write("Do you want to play again? [y/n] ");
            playAgain = Console.ReadLine();
            if (playAgain == "n")
            {
                _isPlaying = false;
            }
        }

        /// <summary>
        /// Displays player score.
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }
    }
}


