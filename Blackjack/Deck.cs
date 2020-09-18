using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        public void Shuffle()
        {
            
        }
        
        public List<Card> CreateADeck()
        {
            List<Card> newList = new List<Card>();
            foreach (var name in Enum.GetNames(typeof(Value)))
            {
                foreach (var suitName in Enum.GetNames(typeof(Suit)))
                {
                    var newCard = new Card(, suitName);
                }
            }
            return newList;
        }

        public void DrawCard()
        {
 
        }
    }
}