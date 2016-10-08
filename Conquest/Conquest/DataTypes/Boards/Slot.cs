using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Conquest
{
    class Slot
    {
        Creature _creature = null;
        public Creature Creature
        {
            get
            {
                return _creature;
            }
            set
            {
                _creature = Creature;
            }
        }
        public Slot() { }

        public void DeleteCreature()
        {
            _creature = null;
        }



    }
}
