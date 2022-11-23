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
        private List<string> _word;
        private List<string> _hint = new List<string>();
        private List<string> _wordBank = new List<string>();
        private int _wordLength;

        /// <summary>
        /// Constructs a new instance of Word. 
        /// </summary>
        public Word()
        {
            _wordBank.Add("a p p l i a n c e");
            _wordBank.Add("e f f e c t");
            _wordBank.Add("c o n t r o l");
            _wordBank.Add("a d m i r e");
            _wordBank.Add("s u g g e s t");
            _wordBank.Add("c l e v e r");
            _wordBank.Add("g l a m o r o u s");
            _wordBank.Add("s p r o u t");
            _wordBank.Add("a n i m a l");
            _wordBank.Add("p r o d u c e");
            _wordBank.Add("s m i l e");
            _wordBank.Add("t o w e r i n g");
            _wordBank.Add("o r g a n i z e");
            _wordBank.Add("b e g i n n e r");
            _wordBank.Add("c h a r m i n g");

            Random rand = new Random();
            int number = rand.Next(_wordBank.Count);
            _word = new List<string>(_wordBank[number].Split(" "));
            _wordLength = _word.Count;
            for (int i = 0; i < _wordLength; i++)
            {
                _hint.Add("_");
            }

        }

        /// <summary>
        /// Displays a hint for the user to guess a letter.
        /// </summary>
        /// <returns>A new hint.</returns>
        public string GetHint()
        {
            string hint = String.Join(" ", _hint);
            return hint;
        }

        /// <summary>
        /// This checks if the user guess is in the word.
        /// </summary>
        public bool CheckGuess(string guess)
        {
            bool isFound = false;
            foreach (string letter in _word)
            {
                if (letter == guess)
                {
                    isFound = true;
                }
            } 
            return isFound;
        }

        /// <summary>
        /// This reveals a letter if the user guessed correctly
        /// </summary>
        public void RevealLetter(string guess)
        {
            for (int i = 0; i < _wordLength; i++)
            {
                if (guess == _word[i])
                {
                    _hint[i] = guess;
                }
            } 
        }

        /// <summary>
        /// Ends the game if user guess the word correctly.
        /// </summary>
        public bool Won()
        {
            bool win = false;
            int correctLetters = 0;
            for (int i = 0; i < _wordLength; i++)
            {
                if (_hint[i] == _word[i])
                {
                    correctLetters += 1;
                }
            } 
            if (correctLetters == _wordLength)
            {
                win = true;
            }
            return win;
        }
        
    }
}