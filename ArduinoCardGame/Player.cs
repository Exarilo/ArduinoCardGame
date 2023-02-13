using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public IEnumerable<Deck> DeckList { get; set; }
        public IEnumerable<Card> CardAvailable { get; set; }

        public Deck deck { get; set; }
        public int Victory { get; set; }
        public int Defeat { get; set; }

        private Hand Hand { get; set; }


        public Player()
        {

        }

            //private List<Card> hand;

        public Player(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("A player must have a name");
            name = name;
            deck = new Deck();
        }


        /*
        public void ReceiveCard(Card card)
        {
            hand.Add(card);
        }*/
        /*
        public void PlayCard(int index)
        {
            if (index >= 0 && index < hand.Count)
            {
                hand.RemoveAt(index);
            }
        }*/
        public virtual void Play()
        {

        }
    }

}
