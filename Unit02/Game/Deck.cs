using System;
using System.Collections.Generic;


namespace HiLo.Game
{
    /// <summary>
    /// The responsibility of Deck is to keep track of its currently dealt value and the points it's
    /// worth.
    /// </summary> 
    public class Deck
    {
        public int _cardValue;

        // public List<string> drawPile;
        // public List<string> discardPile;

        /// <summary>
        /// Constructs a new instance of Deck by assigning a random number.
        /// </summary>
        public Deck()
        {
            Random rnd = new Random();
            _cardValue = rnd.Next(1, 14);
        }

        /// <summary>
        /// Determine whether this card is less than another card.
        /// </summary>
        /// <param name="other"> A different card. </param>
        /// <returns>True if this card is less than the other card. </returns>
        // public bool isLessThan(Deck other)
        // {
        //     return _cardValue < other._cardValue;
        // }

        /// <summary>
        /// Determine whether this card is greater than another card.
        /// </summary>
        /// <param name="other"> A different card. </param>
        /// <returns>True if this card is greater than the other card. </returns>
        // public bool isGreaterThan(Deck other)
        // {
        //     return _cardValue > other._cardValue;
        // }

        // public string DisplayCard()
        // {
        //     Console.WriteLine($"The card is: {_cardValue}");

        // }


    }
}