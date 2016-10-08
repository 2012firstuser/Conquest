using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class Creature
    {
        /// <summary>
        /// Fired when THIS creature attack a creature.
        /// </summary>
        public GameEventArgument.GameEvent CreatureAttacks;
        /// <summary>
        /// Fired when THIS creature is attacked.
        /// </summary>
        public GameEventArgument.GameEvent CreatureIsAttacked;
        /// <summary>
        /// Fired when THIS creature moves.
        /// </summary>
        public GameEventArgument.GameEvent CreatureMoved;
        /// <summary>
        /// Fired when THIS creature dies.
        /// </summary>
        public GameEventArgument.GameEvent CreatureDies;

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
    }
}
