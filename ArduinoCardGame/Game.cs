using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{
    public class Game
    {
        private Deck deck;
        private List<Player> players { get; set; }


        public Game()
        {
            deck = new Deck();
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
            if (!player.deck.ContainCard())
            {
                StarterDeckSelection starterDeckSelection = new StarterDeckSelection(ref player);
                starterDeckSelection.ShowDialog();
            }
        }


        public void Play()
        {

        }
        private void Start()
        {

        }
        private void PlayTurn()
        {

        }
    }

}
