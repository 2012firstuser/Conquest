using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class Player
    {
        Deck _deck;
        Hand _hand;
        Board _board;

        Player(int h, int w)
        {
            _deck = new Deck();
            _hand = new Hand();
            //_board = new Board(h, w);
        }


        public Deck Deck
        {
            get
            {
                return _deck;
            }
            set
            {
                _deck = value;
            }
        }
    }
}
