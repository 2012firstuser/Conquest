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

        public Ability()
        {

        }

        public virtual Ability CreateAbility()
        {
            return new Ability();
        }
    }
}
