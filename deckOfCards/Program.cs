using System;

namespace BlackJack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            Dealer dealer = new Dealer("dealer");
            System.Console.WriteLine("Enter player name:");
            string name = System.Console.ReadLine();
            Player player = new Player(name);
            System.Console.WriteLine("Welcome, {0}.", player.name);
            System.Console.WriteLine("You currently have {0} dollars.", player.money);
            Gameplay.StartGame(player, dealer);
            string action = System.Console.ReadLine();
            Gameplay.Action(action);
        }
    }
}
