using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
   public class Card
    {
        public string FaceValue { get; set; }

        public string  suit { get; set; }

        public string GetFullName()
        {
            return $"{FaceValue} of {suit}";
        }
    }
    
}
