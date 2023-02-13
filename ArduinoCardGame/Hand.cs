using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public class Hand : IPlayable
    {
        private List<Card> cards;
        public List<Card> Cards { get { return cards; } }

        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            cards.Remove(card);
        }

        public void PlayCard(Card card)
        {
            throw new NotImplementedException();
        }

        public void DiscardCard(Card card)
        {
            throw new NotImplementedException();
        }
    }

}
