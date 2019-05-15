using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            game.Dealer = "Jesse";
            game.Name = "TwentyOne";
            game.Players = new List<string>() { "Jesse", "Bill", "Dude" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.ToString());
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine(); //To Se results.
        }
    }
}
