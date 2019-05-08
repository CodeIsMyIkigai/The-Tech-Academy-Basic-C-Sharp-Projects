using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        { 
            Suit = "Spades";
            Face = "Two";
        }

        public Card(string suitIn, string faceIn)
        {
            Suit = suitIn;
            Face = faceIn;
        }

        public string ToString()
        {
            return String.Format("{0} of {1}", Face, Suit);
        }

        public string Suit { get; set; }
        public string Face { get; set; }
        

    }
}
