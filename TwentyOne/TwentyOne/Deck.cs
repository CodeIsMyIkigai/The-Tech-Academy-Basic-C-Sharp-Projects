using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   

    public class Deck
    {

        public Deck()
        {
            this.Cards = new List<Card>();         

            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(Face face in Enum.GetValues(typeof(Face)))
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    this.Cards.Add(card);
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
