using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine(); //To Se results.
        }
    }
}
