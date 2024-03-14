using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class HoldemHand : IComparable<HoldemHand>
    {
        public Card Card1;
        public Card Card2;

        // feels bad to leave public for now, but...
        public List<Card> sharedShared;

        public HoldemHand(Card card1, Card card2)
        {
            Card1 = card1;
            Card2 = card2;
            sharedShared = new List<Card>();
        }

        // TODO check for all 5 shared cards
        public PokerHand GetBestPokerHand()
        {
            List<Card> allCards = new List<Card> { Card1, Card2 };
            allCards.AddRange(sharedShared);
            List<PokerHand> allHands = new List<PokerHand>();

            for (int firstCardIndex = 0; firstCardIndex < 3; firstCardIndex++)
            {
                for (int secondCardIndex = firstCardIndex + 1; secondCardIndex < 4; secondCardIndex++)
                {
                    for (int thirdCardIndex = secondCardIndex + 1; thirdCardIndex < 5; thirdCardIndex++)
                    {
                        for (int fourthCardIndex = thirdCardIndex + 1; fourthCardIndex < 6; fourthCardIndex++)
                        {
                            for (int fifthCardIndex = fourthCardIndex + 1; fifthCardIndex < 7; fifthCardIndex++)
                            {
                                PokerHand hand = new PokerHand();
                                hand.Cards.Add(allCards[firstCardIndex]);
                                hand.Cards.Add(allCards[secondCardIndex]);
                                hand.Cards.Add(allCards[thirdCardIndex]);
                                hand.Cards.Add(allCards[fourthCardIndex]);
                                hand.Cards.Add(allCards[fifthCardIndex]);
                                allHands.Add(hand);
                            }
                        }
                    }
                }
            }

            // better than eric's sort and pick last
            return allHands.Max();
        }

        public int CompareTo(HoldemHand other)
        {
            return GetBestPokerHand().CompareTo(other.GetBestPokerHand());
        }

        public override string ToString()
        {
            return $"{Card1} {Card2}";
        }
    }
}
