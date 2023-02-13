using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public interface IPlayable
    {
        void PlayCard(Card card);
        void DiscardCard(Card card);
    }
}
