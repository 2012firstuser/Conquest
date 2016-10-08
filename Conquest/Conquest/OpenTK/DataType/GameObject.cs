using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using System.Drawing;

namespace Conquest
{
    public class GameObject
    {
        private Texture2D _texture2D;
        private Vector2 _position;
        private Vector2 _scale;
        private Color _color;
        private Vector2 _origin;

        public Texture2D Texture2D
        {
            get
            {
                return _texture2D;
            }

            set
            {
                _texture2D = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return _position;
            }

            set
            {
                _position = value;
            }
        }

        public Vector2 Scale
        {
            get
            {
                return _scale;
            }

            set
            {
                _scale = value;
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public Vector2 Origin
        {
            get
            {
                return _origin;
            }

            set
            {
                _origin = value;
            }
        }

        public GameObject(Texture2D _texture2D, Vector2 _position, Vector2 _scale, Color _color, Vector2 _origin)
        {
            Texture2D = _texture2D;
            Position = _position;
            Scale = _scale;
            Color = _color;
            Origin = _origin;
        }
    }
}
