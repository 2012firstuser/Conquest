using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class Card
    {
        private Type _type;
        List<Ability> _abilities;
        private int power;

        public Card(Type _type,List<Ability> _abilities = null)
        {
            this._type = _type;
            this._abilities = _abilities;
            power = (int)_type;
        }

        public virtual Card CreateCard()
        {
            return null;
        }


    }
}
