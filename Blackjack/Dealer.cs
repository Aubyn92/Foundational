using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace BlackJack
{
    public class Dealer: Person
    {

        public int Play(List<Card> Cards)
        {
   
            // Every time Play() is called, multiple cards in CardsinHand and shuffled deck will change.
            // DrawCard(newCard);
            // Sum();
            // return DetermineBust();

            
                Console.WriteLine("Dealers turn to play.");
            
                while (Sum() < 17)
                {
                    Hit();
                    Console.WriteLine("Dealer's sum = {0}", CardsInHand);
                }
            
                return ;
            
            // while hand_value(dealer_hand)[1] < 17:
            // new_dealer_card = deck.pop()
            // dealer_hand.append(new_dealer_card)
            // print 'Dealer draws %s' % new_dealer_card
            // while (CardsInHand.Length)
     
        }

        public Dealer(string name, List<Card> cardsInHand) : base(name, cardsInHand)
        {
        }
        
        public Dealer(string name) : base(name)
        {
        }
    }
}