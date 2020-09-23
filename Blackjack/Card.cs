using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Blackjack
{
    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum Suit
    {
        Hearts = 1,
        Spades = 2,
        Clubs = 3,
        Diamonds = 4
    }
    
    public class Card
    {

        public Suit Type { get; set; }
        public Value Rank { get; set; }
        
        public Card(Suit type, Value rank)
        {
            Type = type;
            Rank = rank;
        }
        public string FormatCardString()
        {
            var newString = ($"[{Rank.ToString()}, {Type.ToString()}]");
            return newString;
        }

        public List<Card> CardValue()
        {
            Card = Value
                if v
            
            if rank in ranks[0:-4]:
            return int(rank)
            elif rank is 'ACE':
            return 11
            else:
            return 10
        }
    }
}