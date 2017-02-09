using System;

namespace DeckOfCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            System.Console.WriteLine(myDeck);
            System.Console.WriteLine("Enter player name:");
            string name = System.Console.ReadLine();
            Player player = new Player(name);
            System.Console.WriteLine("Welcome, {0}.", player.name);
        }
    }
}
