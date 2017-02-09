using System.Collections.Generic;

namespace DeckOfCards {
    public class Player {
        public string name;
        private List<Card> hand;

        public Player(string n) {
            hand = new List<Card>();
            name = n;
            int money = 100;
        }

        public void DrawFrom(Deck currentDeck) {
            hand.Add(currentDeck.Deal());
        }
    }
}