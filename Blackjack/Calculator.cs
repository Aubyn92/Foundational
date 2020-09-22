using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Blackjack
{
    public class Calculator
    {
        private int SumUpHandCard(List<Card> cards)
        {
            return 3;
            // player_score_label, player_score = hand_value(player_hand)
            // dealer_score_label, dealer_score = hand_value(dealer_hand)
            //
            // if player_score <= 21:
            // dealer_hand_string = '''\nDealer is at %s\nwith the hand %s\n'''
            // print  dealer_hand_string % (dealer_score_label, dealer_hand)
            // else: 
            // print "Dealer wins."
            //
            // while hand_value(dealer_hand)[1] < 17:
            // new_dealer_card = deck.pop()
            // dealer_hand.append(new_dealer_card)
            // print 'Dealer draws %s' % new_dealer_card
        }
    }
}