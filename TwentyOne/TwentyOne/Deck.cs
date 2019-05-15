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
                "Jack", "Queen", "King", "Ace"
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

        public void Shuffle(int times = 1)
        {            
           
            Random random = new Random();
            for (int x = 0; x < times; x++)
            {
                List<Card> TempList = new List<Card>();
                while (this.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, this.Cards.Count);
                    TempList.Add(this.Cards[randomIndex]);
                    this.Cards.RemoveAt(randomIndex);
                }

                this.Cards = TempList;
            }
        }

    }
}
