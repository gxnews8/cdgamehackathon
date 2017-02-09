using System;

namespace DeckOfCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            System.Console.WriteLine(myDeck);
            Player player = new Player("player");
            System.Console.WriteLine(player.name);

        }
    }
}
