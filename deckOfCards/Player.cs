using System.Collections.Generic;

namespace BlackJack {
    public class Player {
        public string name;
        public List<Card> hand;

        public int handTotal;

        public Player(string n) {
            hand = new List<Card>();
            name = n;
            int money = 100;
        }

        public void DrawFrom(Deck currentDeck) {
            hand.Add(currentDeck.Deal());
        }
        public void HandCount(){
            int handTotal = 0;
            bool isAce = false;
            foreach(Card card in hand){
                if (card.val == 11){
                    isAce = true;
                }
                handTotal += card.val; 
            }
            if(isAce == true && handTotal > 21){
                handTotal -= 10;
            }
        }
    }
}