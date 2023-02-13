using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCardGame
{

    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int HP { get; set; }
        public int ManaCost { get; set; }
        public string Type { get; set; }
        public string Familly { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public List<Effect> Effects { get; set; }
        public Card()
        {

        }
        public Card(int id)
        {
            this.Id = Id;
        }
        public Card(string name, int attack, int hp, int manaCost, string description, string picturePath, List<Effect> effects)
        {
            this.Name = name;
            this.Attack = attack;
            this.HP = hp;
            this.ManaCost = manaCost;
            this.Description = description;
            this.PicturePath = picturePath;
            this.Effects = effects;
        }

        /*
        public void Draw(Graphics graphics, int x, int y)
        {
            graphics.DrawImage(Picture, x, y, 150, 200);
            graphics.DrawString(Name, new Font("Arial", 12), Brushes.Black, x + 10, y + 210);
            graphics.DrawString("Attack: " + Attack, new Font("Arial", 10), Brushes.Black, x + 10, y + 225);
            graphics.DrawString("Defense: " + Resistance, new Font("Arial", 10), Brushes.Black, x + 10, y + 240);
            graphics.DrawString("Mana Cost: " + ManaCost, new Font("Arial", 10), Brushes.Black, x + 10, y + 255);
        }*/
        
    }

}
