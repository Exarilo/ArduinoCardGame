using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public enum EffectTrigger
    {
        None,
        OnAppear,
        OnDeath,
        OnTurnStart,
        OnTurnEnd
    }

    public class Effect
    {
        public string Name { get; set; }
        public string Triggers { get; set; }
        public int Damages { get; set; }
        public string Target { get; set; }
    }
}
