
namespace BlackJack {

    public class Gameplay {
        public static void StartGame(Player player, Dealer dealer, Deck gameDeck){
            gameDeck.Shuffle();
            player.DrawFrom(ref gameDeck);
            dealer.DrawFrom(ref gameDeck);
            player.DrawFrom(ref gameDeck);
            ShowCards(player, dealer);
            
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
        public static string Action(string act, Player player, Dealer dealer, Deck gameDeck) {
            string result = "nothing";
            if (act == "hit") {
                System.Console.WriteLine("Player Hit!");
                player.DrawFrom(ref gameDeck);
                player.HandCount();
                System.Console.WriteLine("Player shows {0}", player.handTotal);
                if(player.handTotal > 21){
                    System.Console.WriteLine("You busted!");
                    player.money -= 5;
                    if (player.money > 4){
                        StartGame(player, dealer, gameDeck);
                    }
                }
                result = "Hit";
            }
            if (act == "stay") {
                System.Console.WriteLine("Player Stayed.");
                result = "Stay";
            }
            else {
                System.Console.WriteLine("Player input nonsense.");
                result = "I don't understand. You can 'hit' or 'pass'.";
            }
            return result;
        }
    }
}