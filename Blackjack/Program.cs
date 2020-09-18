﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Blackjack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Card firstCard = new Card(Suit.Diamonds, Value.Eight);
            Card secondCard = new Card(Suit.Hearts, Value.Seven);
            Card thirdCard = new Card(Suit.Spades, Value.Nine);
            
            List<Card> newList = new List<Card>();
            newList.Add(firstCard);
            newList.Add(secondCard);
            newList.Add(thirdCard);
            
            Console.WriteLine("Welcome to Blackjack!");
            
            Player newPlayer = new Player(name: "Liv", isDealer: false, cardsInHand: newList);
            newPlayer.PrintHandCard();
            
            var shuffledCards = new Deck();
            shuffledCards.CreateADeck();
            
            var playerChosenInput = new PlayerInput();
            playerChosenInput.CollectInput();
        }
    }
}