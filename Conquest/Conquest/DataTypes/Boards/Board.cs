using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Conquest
{
    class Board
    {
        private Slot[,] _board;

        public Board(int h, int w)
        {
            _board = new Slot[h, w];
            for(int i = 0; i < h; i++)
            {
                for( int j = 0; j < w; j++)
                {
                    _board[i, j] = new Slot();
                }
            }
        }

        public void PlaceCreature(Point p, Creature _creature)
        {
            _board[p.X, p.y] = _creature;
        }
        
        public Creature GetCreature(Point p)
        {
            return _board[p.X, p.Y].Get();
        }   
        

    }
}
