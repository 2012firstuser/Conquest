using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest.DataTypes.Cards.Implemented
{
    class Queen : Card
    {
        public Queen()
            : base(Type.royalty, new GameObject(AssetManager.GetTexture("Queen.JPG"), Vector2.Zero, new Vector2(1, 1), System.Drawing.Color.AliceBlue, Vector2.Zero))
        { }

        public override Card CreateCard()
        {
            return base.CreateCard();
        }

        public override void Play()
        {
            base.Play();
        }
    }
}
