using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest.DataTypes.Cards.Implemented
{
    public class Jack : Card
    {
        public Jack()
            : base(Type.royalty)
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
