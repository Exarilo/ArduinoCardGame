using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoCardGame
{
    public partial class Board : Form
    {


        public Board()
        {
            InitializeComponent();

        }

        private void Board_Load(object sender, EventArgs e)
        {
            /*
            Deck deck = new Deck();
            deck.Shuffle();


            for (int i = 0; i < 5; i++)
            {
                player1.ReceiveCard(deck.DealCard());
                player2.ReceiveCard(deck.DealCard());
            }

            while (player1.Hand.Count > 0 && player2.Hand.Count > 0)
            {
                Console.WriteLine("Tour de " + player1.Name);
                Console.WriteLine("Main : ");
                for (int i = 0; i < player1.Hand.Count; i++)
                {
                    Console.WriteLine(i + " : " + player1.Hand[i].ToString());
                }
                Console.WriteLine("Choisissez une carte à jouer (index) : ");
                int index = int.Parse(Console.ReadLine());
                player1.PlayCard(index);

                Console.WriteLine("Tour de " + player2.Name);
                player2.Play();

                Console.WriteLine();
            }

            if (player1.Hand.Count == 0)
            {
                Console.WriteLine(player1.Name + " a gagné !");
            }
            else
            {
                Console.WriteLine(player2.Name + " a gagné !");
            }*/
        }
    }
}
