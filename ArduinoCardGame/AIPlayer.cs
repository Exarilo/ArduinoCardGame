using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ArduinoCardGame
{
    public class AIPlayer : Player
    {
        private Random random;

        public AIPlayer(string name) : base(name)
        {
            random = new Random();
        }

        public override void Play()
        {
            //int index = random.Next(Hand.Count);
            //PlayCard(index);
        }
    }
}
