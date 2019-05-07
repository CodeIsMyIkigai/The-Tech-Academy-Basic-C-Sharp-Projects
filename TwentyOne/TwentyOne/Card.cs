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

        public string Suit { get; set; }
        public string Face { get; set; }
        

    }
}
