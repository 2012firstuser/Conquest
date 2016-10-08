using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class Ability
    {
        private Action _abilityAction;
        /// <summary>
        /// Returns the action of the ability;
        /// </summary>
        protected internal Action AbilityAction
        {
            get
            {
                return _abilityAction;
            }
            set
            {
                _abilityAction = value;
            }
        }

        private string _abilityName;
        /// <summary>
        /// Returns the name of the ability.
        /// </summary>
        public string AbilityName
        {
            get
            {
                return _abilityName;
            }
            set
            {
                _abilityName = value;
            }
        }

        public Ability()
        {

        }

        /// <summary>
        /// Creates a new instance of this abiltiy type.
        /// </summary>
        /// <returns></returns>
        public virtual Ability CreateAbility()
        {
            return new Ability();
        }

        public virtual void HandleCreatureIsAttacked(GameEventArgument a)
        {

        }

        public virtual void HandleCreatureAttacks(GameEventArgument a)
        {

        }

        public virtual void HandleCreatureMoves(GameEventArgument a)
        {

        }

        public virtual void HandleCreatureDies(GameEventArgument a)
        {

        }
    }
}
