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
        public Slot() { }

        public void DeleteCreature()
        {
            _creature = null;
        }

        public void AddCreature(Creature c)
        {
            _creature = c;
        }

        public Creature Get()
        {
            return _creature;
        }


    }
}
