using System;
using System.Collections.Generic;
using System.Linq;

namespace NewBlackjackProject
{
    public class Deck
    {
        public List<Card> Cards { get; }

        public Deck()
        {
            Cards = CreateADeck();
        }
        
        private static List<Card> CreateADeck()
        {
            var newList = (from CardFace name in Enum.GetValues(typeof(CardFace)) from Suit suitName in Enum.GetValues(typeof(Suit)) select new Card(name, suitName)).ToList();
            var shuffledList = newList.OrderBy(x => Guid.NewGuid()).ToList();
            return shuffledList;
        }

        public Card PopCard()
        {
            var firstCard = Cards[0];
            Cards.Remove(firstCard);
            return firstCard;
        }
    }
}