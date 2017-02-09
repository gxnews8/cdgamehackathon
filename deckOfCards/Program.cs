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
<<<<<<< HEAD
>>>>>>> 948122726218fe67ad95dd3c85fc27a372eaaa59
=======
            System.Console.WriteLine("You currently have {0} dollars.", player.money);
>>>>>>> 587ea355e3d2cc71e33b589aa722c8b34cf4bbae
        }
    }
}
