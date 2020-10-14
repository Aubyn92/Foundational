using System;
using System.Collections.Generic;

namespace NewBlackjackProject
{
    public class Dealer
    {
        public Hand DealersHand { get; }
        public bool Play(List<Card> cards)
        {
            Console.WriteLine("Dealers turn to play...\n");
            int index = 0;
            Console.WriteLine("The dealers first two cards are: \n");
            DealersHand.PrintHandCard();
            while (DealersHand.Sum() < 17)
            {
                DealersHand.DrawCard(cards[index]);
                index++;
                Console.WriteLine($"Dealer's sum = {DealersHand.Sum()}");
                DealersHand.PrintHandCard();
                if (DetermineBust())
                {
                    return true;
                }
            }
                
            return false;
        }
    }
}