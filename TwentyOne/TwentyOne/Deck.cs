using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   

    public class Deck
    {

        public Deck()
        {
            Cards = new List<Card>();

            List<string> Suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
            List<string> Faces = new List<string> {
                "Two", "Three" , "Four",
                "Five" , "Six", "Seven",
                "Eight", "Nine", "Ten",
                "Eleven", "Twelve", "Ace"
            };

            foreach(string suit in Suits)
            {
                foreach(string face in Faces)
                {
                    Cards.Add(new Card(suit, face));
                }
            }


        }


        public List<Card> Cards { get; set; }
    }
}
