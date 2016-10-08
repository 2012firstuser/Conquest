using OpenTK;
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
        /// <summary>
        /// Returns this card's type.
        /// </summary>
        public Type Type
        {
            get
            {
                return _type;
            }
            private set
            {
                _type = value;
            }
        }

        private List<Ability> _abilities;
        /// <summary>
        /// Returns this card abilities.
        /// </summary>
        protected internal List<Ability> Abilities
        {
            get
            {
                return _abilities;
            }
            set
            {
                _abilities = value;
            }
        }

        private int _power;
        /// <summary>
        /// Returns the damage output of this card.
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

        public GameObject Obj
        {
            get
            {
                return _obj;
            }

            set
            {
                _obj = value;
            }
        }

        private GameObject _obj;

        public Card(Type _type, GameObject _obj, List<Ability> _abilities = null)
        {
            this._obj = _obj;
            Type = _type;
            Abilities = _abilities;
            Power = (int)_type;
        }

        /// <summary>
        /// Creates another instance of this card.
        /// </summary>
        /// <returns></returns>
        public virtual Card CreateCard()
        {
            return null;
        }

        /// <summary>
        /// Called when this card is discarded.
        /// </summary>
        public virtual void Discard()
        {

        }

        /// <summary>
        /// Called when the user plays the card.
        /// </summary>
        public virtual void Play()
        {

        }
    }
}
