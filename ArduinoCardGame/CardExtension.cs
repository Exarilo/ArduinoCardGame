using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public static class CardExtensions
    {
        public static bool ContainCard(this Deck deck)
        {
            return deck != null && deck.Count != 0;
        }
    }
}