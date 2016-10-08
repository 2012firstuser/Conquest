using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    static class FightManager
    {
        /// <summary>
        /// Creature A is attacking B. 
        /// Invincibulity only triggers when defending (so only B)
        /// Returns 0 if B dies, 1 if A dies, 2 if Both die and 3 if neither die. 
        /// </summary>
        public static int Fight(Creature a, Creature b)
        {
            GameEventArgument defend = new GameEventArgument(b, a);
            GameEventArgument attack = new GameEventArgument(a, b);

            a.CreatureAttacks(attack);
            b.CreatureIsAttacked(defend);
                
            if (b.Invicable)
            {
                if (b.Power >= a.Power)
                    return 1;
                else
                    return 3;
            }
            if (a.Invicable)
            {
                if (a.Power >= b.Power)
                    return 0;
                else
                    return 3;
            }
            if (a.Power == b.Power)
                return 2;
            if (a.Power > b.Power)
                return 0;
            else (b.Power > a.Power)
                return 1;
            return null;
        }
    }
}
