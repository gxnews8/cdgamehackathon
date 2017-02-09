using System;
using System.Collections.Generic;

namespace DeckOfCards {
    public class Deck {
        private List<Card> cards;

        public Deck() {
            Reset();
        }

        public Card Deal() {
            if(cards.Count > 0) {
                Card temp = cards[0];
                cards.RemoveAt(0);
                return temp;
            }
            return null;
        }

        public Deck Shuffle() {
            Random rand = new Random();
            for(int i = cards.Count - 1; i > 0; i--) {
                int randIdx = rand.Next(i);
                Card temp = cards[randIdx];
                cards[randIdx] = cards[i];
                cards[i] = temp;
            }
            return this;
        }

        public Deck Reset() {
            cards = new List<Card>();
            string[] suits = new string[4] {"Hearts", "Clubs", "Spades", "Diamonds"};
            foreach(string suit in suits) {
                for (int val = 1; val < 14; val++) {
                    cards.Add(new Card(suit, val));
                }
            }
            return this;
        }

        public override string ToString() {
            string info = "";
            foreach(Card card in cards) {
                info += card + "\n";
            }
            return info;
        }
    }
}