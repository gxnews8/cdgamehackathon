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
            
            // C# I need to learn hard.
            while (player.money > 4){
                string returnval = Gameplay.StartGame(player, dealer, myDeck);
                if (returnval == "hit"){
                    Gameplay.Action(player, dealer, myDeck);
                }else if (returnval == "stay"){
                    dealer.PitBoss(myDeck, player);
                }else if(returnval == "void"){
                    Gameplay.Action(player, dealer, myDeck);
                }
            }
        }
    }
}
