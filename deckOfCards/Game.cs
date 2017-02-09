
namespace BlackJack {

    public class Gameplay {
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
>>>>>>> c406104e83a03cdde41fcb0a63c71ac6ac38f861
=======
namespace BlackJack{
>>>>>>> max
    
}