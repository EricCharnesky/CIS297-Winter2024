using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        private List<Card> cards;
        private Random random;
        public Deck()
        {
            cards = new List<Card>();
            foreach (Card.Face face in Enum.GetValues(typeof(Card.Face)))
            {
                foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
                {
                    cards.Add(new Card(face, suit));
                }
            }
            random = new Random();

        }

        public Card DealCard()
        {
            int randomCardIndex = random.Next(cards.Count);
            Card card = cards[randomCardIndex];
            cards.RemoveAt(random.Next(cards.Count));
            return card;

        }
    }
}
