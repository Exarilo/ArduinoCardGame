using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{

    public class Deck : IDeck
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Card> Cards { get; set; }
        public int Victory { get; set; }
        public int Defeat { get; set; }



        private Random random;
        public Deck()
        {
       
            random = new Random();
        }

        public void AddCard(Card card)
        {
           // Cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
           // Cards.Remove(card);
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => random.Next()).ToList();
        }

        public Card Draw()
        {
            /*
            if (Cards.Count == 0)
            {
                return null;
            }

            Card drawnCard = Cards[0];
            Cards.RemoveAt(0);
            return drawnCard;*/
            return null;
        }

        public Card DealCard()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            //    get { return Cards.Count; }
            get { return 0; }
        }
    }

}
