using System.Collections.Generic;

namespace BlackJack
{
    public class Dealer: Person
    {

        public int Play(List<Card> Cards)
        {
            // Continuous hitting until 17 then print result.
            // Then start winning logic functions of compare player and Dealer hand card sum value.
            // Every time Play() is called, multiple cards in CardsinHand and shuffled deck will change.
            DrawCard(newCard);
            // Sum();
            // return DetermineBust();

            while (Sum())
            {
                
            }

            // while loop - until 17
            
            // while hand_value(dealer_hand)[1] < 17:
            // new_dealer_card = deck.pop()
            // dealer_hand.append(new_dealer_card)
            // print 'Dealer draws %s' % new_dealer_card
            // while (CardsInHand.Length)
            // {
            //     
            // }
        }

        public Dealer(string name, List<Card> cardsInHand) : base(name, cardsInHand)
        {
        }
        
        public Dealer(string name) : base(name)
        {
        }
    }
}