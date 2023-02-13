using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArduinoCardGame
{
    public partial class Menu : Form
    {
        private Player player1 = new Player("Player 1");
        private AIPlayer player2 = new AIPlayer("IA");
        private Game game = new Game();

        public Menu()
        {
            InitializeComponent();

            //RECUPERER LES JOUEURS DANS UNE BDD CELON L'ID DE LA CARTE OU API 
          //  game.AddPlayer(player1);
          //  game.AddPlayer(player2);



        }

        private void Menu_Load(object sender, EventArgs e)
        {
            game.Load();
        }
        private void LoadXml()
        {


        }
    }
}
