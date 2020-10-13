using System;
using System.Collections.Generic;

namespace NewBlackjackProject
{
    public class Player
    {
        public Hand PlayersHand { get; }
        public bool Hit(Card newCard)
        {
            PlayersHand.DrawCard();
            PlayersHand.Sum();
            Console.WriteLine($"You are currently at {PlayersHand.Sum()}");
            return PlayersHand.DetermineBust();
        }
    }
}