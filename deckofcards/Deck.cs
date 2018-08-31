using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    class Deck
    {
        public Card[] cards { get; set; }

        public Deck(int numberofCards)
        {
            cards = new Card[52];
        }
        public Card Draw()
        {
            var random = new Random();
            var number = random.Next(cards.Length);
            return cards[number];
        }

         
    }
    
}
