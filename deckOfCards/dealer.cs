using System.Collections.Generic;
using System;

namespace BlackJack {
    public class Dealer : Player{ 
       public Dealer(string name) : base(name){
        name="Dealer";
       }
        public string DealerAction;

        public Player PitBoss( Deck myDeck, Player player){
            int DealerSum=handTotal;
            if(DealerSum<player.handTotal || DealerSum<17){
                DrawFrom(ref myDeck);
                DealerAction="Dealer Draws";
            }
            else{
                DealerAction="Dealer Stays";
            }
        }
    }
}
