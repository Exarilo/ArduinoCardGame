using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public class Player
    {
        private string name;
        private Hand hand;
        public Deck deck { get; set; }
        //private List<Card> hand;

        public Player(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("A player must have a name");
            name = name;
            deck = new Deck();
        }

        public string Name
        {
            get { return name; }
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
