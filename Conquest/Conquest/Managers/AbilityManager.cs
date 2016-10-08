﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    static class AbilityManager
    {
        private static List<Ability> _abilities = new List<Ability>()
        {

        };

        /// <summary>
        /// Iterate through the _abilities and find requested ability by name.
        /// </summary>
        /// <param name="abilityName"></param>
        /// <returns></returns>
        public static Ability GetAbility(string abilityName)
        {
            return _abilities.Find((a) => { return a.AbilityName == abilityName; });
        }

        /// <summary>
        /// Binds the given ability to the creature.
        /// </summary>
        /// <param name="creature">Target creature</param>
        /// <param name="ability">Target ability</param>
        public static void BindAbilitiy(Creature creature, Ability ability)
        {
            creature.Abilities.Add(ability);

            creature.CreatureAttacks += ability.HandleCreatureAttacks;
            creature.CreatureDies += ability.HandleCreatureDies;
            creature.CreatureIsAttacked += ability.HandleCreatureIsAttacked;
            creature.CreatureMoved += ability.HandleCreatureMoves;
        }

        /// <summary>
        /// Unbinds the given ability from the creature.
        /// </summary>
        /// <param name="creature">Target creature</param>
        /// <param name="ability">Target ability</param>
        public static void UnbindAbility(Creature creature, Ability ability)
        {
            creature.Abilities.Remove(ability);

            creature.CreatureAttacks -= ability.HandleCreatureAttacks;
            creature.CreatureDies -= ability.HandleCreatureDies;
            creature.CreatureIsAttacked -= ability.HandleCreatureIsAttacked;
            creature.CreatureMoved -= ability.HandleCreatureMoves;
        }
    }
}
