using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public interface IDeck
    {
        void Shuffle();
        Card DealCard();
    }
}
