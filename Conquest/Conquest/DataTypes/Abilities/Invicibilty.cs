using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest.DataTypes.Abilities
{
    public class Invicibilty : Ability
    {
        public override void HandleCreatureAttacks(GameEventArgument a) 
        {
            base.HandleCreatureAttacks(a);
        }
        public override void HandleCreatureDies(GameEventArgument a)
        {
            base.HandleCreatureDies(a);
        }
        public override void HandleCreatureIsAttacked(GameEventArgument a)
        {
            base.HandleCreatureIsAttacked(a);
        }
        public override void HandleCreatureMoves(GameEventArgument a)
        {
            base.HandleCreatureMoves(a);
        }


    }
}
