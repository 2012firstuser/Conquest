using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using OpenTK;

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

        public GameObject GameObject
        {
            get
            {
                return _gameObject;
            }

            set
            {
                _gameObject = value;
            }
        }

        GameObject _gameObject;

        public Slot(Vector2 _position)
        {
            _gameObject = new GameObject(AssetManager.GetTexture("Slot.PNG"), _position, new Vector2(0, 0), Color.White, new Vector2(0, 0));
            DrawManager.AddToQueue(_gameObject);
        }

        public void DeleteCreature()
        {
            _creature = null;
        }



    }
}
