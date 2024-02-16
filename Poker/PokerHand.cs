using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class PokerHand : IComparable<PokerHand>
    {
        public enum Rank { HighCard, Pair, TwoPair, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush }
        // TODO - this feels bad
        public List<Card> Cards { get; set; }

        public PokerHand() { 
            Cards = new List<Card>();
        }

        public Rank GetHandRank()
        {
            // TODO - FIXME
            return Rank.HighCard;
        }

        public int CompareTo(PokerHand? other)
        {
            // TODO - might not need if we always have 5 cards
            if ( Cards.Count != 5 || other.Cards.Count != 5)
            {
                throw new ArgumentException();
            }

            if ( GetHandRank() != other.GetHandRank())
            {
                return GetHandRank() - other.GetHandRank();
            }
            // TODO - TIEBREAK - each rank is a little special

            Cards.Sort();
            other.Cards.Sort();
            return 0;

        }

        public override string ToString()
        {
            Cards.Sort();
            
            // TODO - do this better if we care
            string result = "";
            foreach (Card card in Cards)
            {
                result += card.ToString() + " ";
            }
            result += $"{GetHandRank()}";
           // result = result.ToAlternating();
            return result;
        }

        
    }
}
