using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck
    {
        public List<Card> CreateADeck()
        {
            List<Card> newList = new List<Card>();
            foreach(Value name in Enum.GetValues(typeof(Value)))
            {
                foreach(Suit suitName in Enum.GetValues(typeof(Suit)))
                {
                    var newCard = new Card(suitName, name);
                    newList.Add(newCard);
                }
            }
            return newList;
        }

        public Card DrawCard(List<Card> newListOfCards)
        {
            Random rnd = new Random();
            int cardInt = rnd.Next(newListOfCards.Count);
            var randomCard = newListOfCards[cardInt];
            return randomCard;
        }
    }
}