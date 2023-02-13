using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{

    public class Deck : IDeck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            cards.Remove(card);
        }

        public void Shuffle()
        {
            cards = cards.OrderBy(c => random.Next()).ToList();
        }

        public Card Draw()
        {
            if (cards.Count == 0)
            {
                return null;
            }

            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

        public Card DealCard()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return cards.Count; }
        }
    }

}
