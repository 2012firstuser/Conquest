using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest.DataTypes.Cards.Implemented
{
    public class Priest : Card
    {
        public Priest()
            : base(Type.priest)
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
