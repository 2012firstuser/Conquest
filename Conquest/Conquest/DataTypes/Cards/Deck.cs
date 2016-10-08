using Conquest.DataTypes.Cards.Implemented;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
   
    public class Deck
    {
        private List<Card> _deck = new List<Card>()
        {
            new Priest(),
            new Priest(),
            new Peasant(),
            new Peasant(),
            new FootSoldier(),
            new FootSoldier(),
            new Assassin(),
            new Assassin(),
            new Commander(),
            new Commander(),
            new Jack(),
            new Jack(),
            new Jack(),
            new Jack(),
            new Knight(),
            new Knight(),
            new Merchant(),
            new Merchant(),
            new Queen(),
            new Queen(),
            new King(),
            new King(),
        };

        /// <summary>
        /// Creates a deck with 26 cards
        /// 2x each basic card
        /// 4x hiers
        /// 1x queen and king
        /// </summary>
        public Deck()
        {
            for(int i = 0; i < 10; i++)
            {
               
            }   
        }
        /// <summary>
        /// Returns a random card from the deck and removes it
        /// </summary>
        /// <returns>Random card</returns>
        public Card Draw()
        {
            if (_deck.Count == 0)
                return null;
            int cardNumber = Util.Random.Next(0,_deck.Count -1);
            Card r = _deck[cardNumber];
            _deck.RemoveAt(cardNumber);
            return r;
        }
        /// <summary>
        /// Adds a new card to the deck. 
        /// </summary>
        public void Add(Card _card)
        {
            _deck.Add(_card);
        }
    }
}
