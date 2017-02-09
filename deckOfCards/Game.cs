
namespace BlackJack {

    public class Gameplay {
        public static void StartGame(Player player, Dealer dealer){
            Deck gameDeck = new Deck();
            gameDeck.Shuffle();
            player.DrawFrom(ref gameDeck);
            dealer.DrawFrom(ref gameDeck);
            player.DrawFrom(ref gameDeck);
            dealer.DrawFrom(ref gameDeck);
            System.Console.WriteLine("Player Cards:");
            foreach(Card card in player.hand){
                System.Console.WriteLine(card.val);
            }
            System.Console.WriteLine("Dealer Showing Card:");
            System.Console.WriteLine(dealer.hand[1].val);
            
        }
        public static string Action(string act) {
            string result = "nothing";
            if (act == "hit") {
                System.Console.WriteLine("Player Hit!");
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