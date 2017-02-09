using System.Collections.Generic;
using System;

namespace BlackJack {
    public class Dealer : Player{ 
       public Dealer(string name) : base(name){
        name="Dealer";
       }
        public string DealerAction;

        public Player PitBoss(string name){

            int DealerSum=0;
            foreach(Card card in hand){
                DealerSum+=card.val;
            }
            if(DealerSum<handTotal || DealerSum<17){
                Player.DrawFrom(ref myDeck);
                DealerAction="Dealer Draws";
            }
            else{
                DealerAction="Dealer Stays";
            }
        }
    }
}
