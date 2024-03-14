using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Poker
{
    public class PokerHand : IComparable<PokerHand>
    {
        public enum Rank { HighCard, Pair, TwoPair, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush }
        // TODO - this feels bad
        public List<Card> Cards { get; set; }

        public PokerHand() { 
            Cards = new List<Card>();
        }

        public Rank GetHandRank()
        {
            if (HasStraight() && HasFlush())
            {
                return Rank.StraightFlush;
            }
            if (HasNOfAKind(4))
            {
                return Rank.FourOfAKind;
            }
            if (HasNOfAKind(3) && HasNOfAKind(2))
            {
                return Rank.FullHouse;
            }
            if (HasFlush())
            {
                return Rank.Flush;
            }
            if (HasStraight())
            {
                return Rank.Straight;
            }
            if (HasNOfAKind(3))
            {
                return Rank.ThreeOfAKind;
            }
            if(HasNOfAKind(2, 2))
            {
                return Rank.TwoPair;
            }
            if (HasNOfAKind(2))
            {
                return Rank.Pair;
            }
            return Rank.HighCard;
        }

        /*
         * UMGPT :  
         * prompt 1: can you explain what this is doing? return Cards.GroupBy(card => card.face)
                .Where(group => group.Count() == 4).ToList().Count == 1;
         * prompt 2: can you write a similar method that checks for a hand with a straight
       
         */
        public bool HasStraight()
        {
            // Assuming we have a way to convert the card face to a numerical value
            var orderedCards = Cards.Select(card => card.face)
                                    .OrderBy(numericValue => numericValue)
                                    .ToList();

            int sequentialCards = 1;

            for (int i = 1; i < orderedCards.Count; i++)
            {
                if (orderedCards[i] == orderedCards[i - 1] + 1)
                {
                    // Found two consecutive cards, increase the counter
                    sequentialCards++;
                }
                else if (orderedCards[i] != orderedCards[i - 1])
                {
                    // Reset counter because the values are not consecutive (and not a duplicate)
                    sequentialCards = 1;
                }

                // If we have found at least 5 consecutive values, return true for a straight
                if (sequentialCards >= 5)
                    return true;
            }

            return false; // No straight found in the hand
        }

        private bool HasFlush()
        {
            return Cards.GroupBy(card => card.suit).ToList().Count == 1;
        }

        private bool HasNOfAKind(int numberOfOccurances, int numberOfReatingOccurances = 1)
        {
            List<int> faceCounts = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (Card card in Cards)
            {
                faceCounts[(int)card.face]++;
            }

            if (numberOfReatingOccurances == 1)
            {
                return faceCounts.Contains(numberOfOccurances);
            }
            

            return Cards.GroupBy(card => card.face)
                  .Where(group => group.Count() == numberOfOccurances).ToList().Count == numberOfReatingOccurances;

        }

        public int CompareTo(PokerHand? other)
        {
            // TODO - might not need if we always have 5 cards
            if (Cards.Count != 5 || other.Cards.Count != 5)
            {
                throw new ArgumentException();
            }

            if (GetHandRank() != other.GetHandRank())
            {
                return GetHandRank() - other.GetHandRank();
            }
            // TODO - TIEBREAK - each rank is a little special

            List<int> faceCounts = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (Card card in Cards)
            {
                faceCounts[(int)card.face]++;
            }
            Cards.Count(card => card.face == Card.Face.Ace);

            var faceValueCounts = Cards.GroupBy(card => card.face)
                                        // new keyword creates an anonymous class with the attributes as named
                                       .Select(group => new { FaceValue = group.Key, Count = group.Count() })
                                       .OrderBy(x => x.FaceValue); // Optional: ordering by FaceValue for display

            var otherFaceValueCounts = other.Cards.GroupBy(card => card.face)
                                       .Select(group => new { FaceValue = group.Key, Count = group.Count() })
                                       .OrderBy(x => x.FaceValue); // Optional: ordering by FaceValue for display


            // Two pair
            if ( faceValueCounts.Count( faceCount => faceCount.Count == 2) == 2)
            {
                // find just the face values counts that have a count of 2 - pairs
                var pairs = faceValueCounts.Where( faceCount => faceCount.Count == 2)
                    .OrderByDescending(x => x.FaceValue).ToList();
                var otherPairs = otherFaceValueCounts.Where(faceCount => faceCount.Count == 2)
                    .OrderByDescending(x => x.FaceValue).ToList();
                
                for ( int index = 0; index < pairs.Count; index++ )
                {
                    if (pairs[index].FaceValue < otherPairs[index].FaceValue)
                    {
                        return -1;
                    }
                    else if (pairs[index].FaceValue > otherPairs[index].FaceValue)
                    {
                        return 1;
                    }
                }

                // get just face value counts where count is 1, compare that face value to the other face value
                return faceValueCounts.Where(faceCount => faceCount.Count == 1).ToList()[0].FaceValue -
                    otherFaceValueCounts.Where(faceCount => faceCount.Count == 1).ToList()[0].FaceValue;

            }

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
