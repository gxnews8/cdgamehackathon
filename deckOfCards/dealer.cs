using System.Collections.Generic;
using System;

namespace BlackJack {
    public class Dealer : Player{ 
       public Dealer(string name) : base(name){
        name="Dealer";
       }
        public string DealerAction;

        public void PitBoss( Deck myDeck, Player player){
            HandCount();
            while(handTotal<player.handTotal-1 && handTotal < 22){
                DrawFrom(ref myDeck);
                Gameplay.ShowCards(player, this);
                DealerAction="Dealer Draws";
            }
            if(handTotal < 22){
                System.Console.WriteLine("Dealer Wins!");
                player.money -= 5;
            }else{
                System.Console.WriteLine("Player Wins!");
                player.money +=5;
            }
        }
    }
}
