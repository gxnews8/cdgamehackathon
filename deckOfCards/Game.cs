
namespace BlackJack {

    public class Gameplay {
        public static string StartGame(Player player, Dealer dealer, Deck gameDeck){
            System.Console.WriteLine("You currently have {0} dollars.", player.money);
            gameDeck.Reset();
            gameDeck.Shuffle();
            player.hand.Clear();
            dealer.hand.Clear();
            player.DrawFrom(ref gameDeck);
            dealer.DrawFrom(ref gameDeck);
            player.DrawFrom(ref gameDeck);
            ShowCards(player, dealer);
            string returnVal = Gameplay.Action(player, dealer, gameDeck);
            return returnVal;
            
        }
        public static void ShowCards(Player player, Dealer dealer){
            System.Console.WriteLine("Player Cards:");
            foreach(Card card in player.hand){
                System.Console.WriteLine(card.val);
            }
            System.Console.WriteLine("Dealer Showing Card(s):");
            foreach(Card card in dealer.hand){
                System.Console.WriteLine(card.val);
            }
        }
        public static string Action(Player player, Dealer dealer, Deck gameDeck) {
            string act = System.Console.ReadLine();
            if (act == "hit") {
                System.Console.WriteLine("Player Hit!");
                player.DrawFrom(ref gameDeck);
                player.HandCount();
                ShowCards(player, dealer);
                System.Console.WriteLine("Player shows {0}", player.handTotal);
                if(player.handTotal > 21){
                    System.Console.WriteLine("You busted!");
                    player.money -= 5;
                    return "bust";
                }else {
                    Action(player, dealer, gameDeck);
                }
            }
            if (act == "stay") {
                System.Console.WriteLine("Player Stayed.");
                dealer.PitBoss(gameDeck, player);
                return "stay";
            }
            else {
                System.Console.WriteLine("I don't understand. You can 'hit' or 'pass'.");
                return "void";
            }
        }
    }
}