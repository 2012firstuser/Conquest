using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class Creature
    {
        private int _power;
        /// <summary>
        /// Returns this creature's power.
        /// </summary>
        public int Power
        {
            get
            {
                return _power;
            }
            private set
            {
                _power = value;
            }
        }

        private List<Ability> _abitities = new List<Ability>();
        /// <summary>
        /// Returns this creature's abilities.
        /// </summary>
        public List<Ability> Abilities
        {
            get
            {
                return _abitities;
            }
            private set
            {
                _abitities = value;
            }
        }

        public 
    }
}
