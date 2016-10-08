using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    class Board
    {
        private Slot[,] _board;

        public Board(int h, int w)
        {
            _board = new Slot[h, w];
        }

//        public void PlaceCard(Point)
//        {

//        }

    }
}
