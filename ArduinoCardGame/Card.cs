using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class Card
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Resistance { get; set; }
        public int ManaCost { get; set; }
        public string Description { get; set; }
        public Bitmap Picture { get; set; }
        public EffectTrigger EffectTrigger { get; set; }
        public Card(string name, int attack, int defense, int manaCost, string description, Bitmap picture, EffectTrigger effectTrigger)
        {
            this.Name = name;
            this.Attack = attack;
            this.Resistance = defense;
            this.ManaCost = manaCost;
            this.Description = description;
            this.Picture = picture;
            this.EffectTrigger = effectTrigger;
        }

        public void Draw(Graphics graphics, int x, int y)
        {
            graphics.DrawImage(Picture, x, y, 150, 200);
            graphics.DrawString(Name, new Font("Arial", 12), Brushes.Black, x + 10, y + 210);
            graphics.DrawString("Attack: " + Attack, new Font("Arial", 10), Brushes.Black, x + 10, y + 225);
            graphics.DrawString("Defense: " + Resistance, new Font("Arial", 10), Brushes.Black, x + 10, y + 240);
            graphics.DrawString("Mana Cost: " + ManaCost, new Font("Arial", 10), Brushes.Black, x + 10, y + 255);
        }
    }

}
