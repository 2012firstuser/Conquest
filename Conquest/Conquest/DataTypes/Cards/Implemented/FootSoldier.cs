using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest.DataTypes.Cards.Implemented
{
    public class FootSoldier : Card
    {
        public FootSoldier()
            : base(Type.foot_soldier)
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
