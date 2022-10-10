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
            // drawPile = new List<string>{
            //     "1", "1", "1", "1",                
            //     "2", "2", "2", "2",                
            //     "3", "3", "3", "3",                
            //     "4", "4", "4", "4",                
            //     "5", "5", "5", "5",                
            //     "6", "6", "6", "6",                
            //     "7", "7", "7", "7",                
            //     "8", "8", "8", "8",                
            //     "9", "9", "9", "9",                
            //     "10", "10", "10", "10",
            //     "11", "11", "11", "11",
            //     "12", "12", "12", "12",
            //     "13", "13", "13", "13"
            // };

            // discardPile = new List<string>();
        }

        // summary below turns into a help when hovered over when referenced
        /// <summary>

        /// </summary>

        // public void Draw()
        // {
        //     Random rnd = new Random();
        //     int _card = rnd.Next(1, 14);
        //     // return _card;
        // }

        // public void Discard(string card){

        // }  

        // public void ReturnCard(string card){

        // }

        // public void Shuffle(){

        // }
    }
}