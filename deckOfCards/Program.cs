using System;

namespace DeckOfCards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            System.Console.WriteLine(myDeck);
<<<<<<< HEAD
            Player player = new Player("player");
            System.Console.WriteLine(player.name);

=======
            System.Console.WriteLine("Enter player name:");
            string name = System.Console.ReadLine();
            Player player = new Player(name);
            System.Console.WriteLine("Welcome, {0}.", player.name);
>>>>>>> 948122726218fe67ad95dd3c85fc27a372eaaa59
        }
    }
}
