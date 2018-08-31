using System;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(52);

            var counter = 0;

            for (int i = 2; i <= 14; i++)


            {
                for (int j = 1; j <= 4; j++)
                {
                    string facevalue;

                    if (i < 11) facevalue = i.ToString();
                    else if (i == 11) facevalue = "Jack";
                    else if (i == 12) facevalue = "Queen";
                    else if (i == 13) facevalue = "king";
                    else facevalue = "Ace";

                    string suit;

                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Diamonds";
                    else if (j == 3) suit = "spades";
                    else suit = "clubs";

                    deck.cards[counter] = new Card
                    {
                        FaceValue = facevalue,
                        suit = suit
                    };

                    counter++;
                }


            }
                
   
             var card = deck.Draw();

            Console.WriteLine(card.GetFullName());

            Console.ReadLine();
        }
    }
}
