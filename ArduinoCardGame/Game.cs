using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArduinoCardGame
{
    public class Game
    {
        private Deck deck;
        private IEnumerable<Player> players { get; set; } 
        private IEnumerable<Card> allCards { get; set; }

        public Game()
        {
            deck = new Deck();

        }
        public void Load()
        {

            LoadExistingCards();
            LoadExistingPlayers();
        }
        public void AddPlayer(Player player)
        {
            /*
            players.Add(player);
            if (!player.deck.ContainCard())
            {
                StarterDeckSelection starterDeckSelection = new StarterDeckSelection(ref player);
                starterDeckSelection.ShowDialog();
            }*/
        }

        
        private void LoadExistingPlayers()
        {



            XDocument xDoc = XDocument.Load(Constant.XML_UserPath);
            players = from player in xDoc.Descendants("Player")
                      select new Player
                      {
                          Id = player.Attribute("id").Value,
                          Name = player.Element("Name").Value,
                          Rank = Convert.ToInt32(player.Element("Rank").Value),
                          DeckList = (from deck in player.Descendants("Deck")
                                      select new Deck
                                      {
                                          Id = deck.Attribute("id").Value,
                                          Name = deck.Element("Name").Value,
                                          Cards = (from card in deck.Descendants("Card")
                                                  select allCards.Where(x => x.Id.ToString() == card.Attribute("id").Value)),
                                          Victory = Convert.ToInt32(deck.Element("Victory").Value),
                                          Defeat = Convert.ToInt32(deck.Element("Defeat").Value)
                                      }).ToList(),
                          CardAvailable = (IEnumerable<Card>)(from card in player.Descendants("CardAvailable")
                                                              select allCards.Where(x => x.Id.ToString() == card.Attribute("id").Value)),

                          Victory = Convert.ToInt32(player.Element("Stats").Element("Victory").Value),
                          Defeat = Convert.ToInt32(player.Element("Stats").Element("Defeat").Value)
                          
                      };

        }
        private void LoadExistingCards()
        {
            var xml = XDocument.Load(Constant.XML_CardPath);
            allCards = (from card in xml.Descendants("Card")
                         select new Card
                         {
                             Id = card.Attribute("id").Value,
                             Name = card.Element("Name").Value,
                             Attack = int.Parse(card.Element("Attack").Value),
                             HP = int.Parse(card.Element("HP").Value),
                             ManaCost = int.Parse(card.Element("ManaCost").Value),
                             Type = card.Element("Type").Value,
                             Familly = card.Element("Familly").Value,
                             Description = card.Element("Description").Value,
                             PicturePath = card.Element("PicturePath").Value,
                             Effects = (from effect in card.Elements("Effect")
                                        select new Effect
                                        {
                                            Name = effect.Element("Name").Value,
                                            Triggers = effect.Element("Triggers").Value,
                                            Damages = int.Parse(effect.Element("Damages").Value),
                                            Target = effect.Element("Target").Value
                                        }).ToList()
                         }).ToList();

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


