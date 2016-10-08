using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using OpenTK;

namespace Conquest
{
    class Board
    {
        private List<Slot> _board = new List<Slot>();
        private int _gravity=1;

        public int Gravity
        {
            get
            {
                return _gravity;
            }

            set
            {
                _gravity = value;
            }
        }

        public Board(Vector2 offput, int h, int w, int _gravity)
        {
            this._gravity = _gravity;
            for(int i = 0; i < h; i++)
            {
                for( int j = 0; j < w; j++)
                {
                    _board.Add(new Slot(new Vector2(i * 300,j * 500) - offput, Color.White));
                }
            }

            if (_gravity == 1)
            {
                for (int i = 0; i < h; i++)
                {
                    _board.Add(new Slot(new Vector2(i * 300, -600) - offput, Color.Red));
                }
            }
            else
            {
                for (int i = 0; i < h; i++)
                {
                    _board.Add(new Slot(new Vector2(i * 300, w*500 + 100) - offput, Color.Red));
                }
            }
        }

        //public void PlaceCreature(Point p, Creature _creature)
        //{
        //    _board[p.X, p.Y].Creature = _creature;
        //}
        
        //public Creature GetCreature(Point p)
        //{
        //    return _board[p.X, p.Y].Creature;
        //}   
        

    }
}
