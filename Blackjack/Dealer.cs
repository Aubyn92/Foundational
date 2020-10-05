using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace BlackJack
{
    public class Dealer: Person
    {

        public bool Play(List<Card> cards)
        {
            Console.WriteLine("Dealers turn to play...\n");
                int index = 0;
                Console.WriteLine("The dealers first two cards are: \n");
                PrintHandCard();
                Console.WriteLine($"Dealer is currently at: {Sum()}");
                while (Sum() < 17)
                {
                    DrawCard(cards[index]);
                    index++;
                    PrintHandCard();
                    Console.WriteLine($"Dealer is currently at: {Sum()}");
                    if (DetermineBust())
                    {
                        return true;
                    }
                }
                
                if (DetermineBlackjack())
                {
                    Console.WriteLine("Dealer has won Blackjack!!! Yay!");
                    Environment.Exit(1);
                }
                
                return false;
        }

        public Dealer(string name, List<Card> cardsInHand) : base(name, cardsInHand)
        {
        }
        
        public Dealer(string name) : base(name)
        {
        }
    }
}