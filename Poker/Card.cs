using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card : IComparable<Card>
    {
        public enum Face { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
        public enum Suit { Spades, Hearts, Clubs, Diamonds }

        public Face face { get; set; }
        public Suit suit { get; set; }

        public Card( Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public int CompareTo(Card? other) => face - other.face;

        public override string ToString()
        {
            return $"{face} of {suit}";
        }
    }
}
