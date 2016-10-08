using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
   
    class Deck
    {
        private List<Card> _deck;

        public Deck()
        {
            for(int i = 0; i < 10; i++)
            {
               
            }   
        }

        public Card Draw()
        {
            if (_deck.Count == 0)
                return null;
            int cardNumber = Util.Random.Next(0,_deck.Count -1);
            Card r = _deck[cardNumber];
            _deck.RemoveAt(cardNumber);
            return r;
        }

    }
}
