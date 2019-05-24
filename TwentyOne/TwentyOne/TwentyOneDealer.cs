using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class TwentyOneDealer: Dealer
    {
        private List<Card> _Hand = new List<Card>();
        public List<Card> Hand { get { return _Hand; } set { _Hand = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
