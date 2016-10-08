using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class GameEventArgument
    {
        /// <summary>
        /// The delegate for firing game events.
        /// </summary>
        /// <param name="a"></param>
        public delegate void GameEvent(GameEventArgument a);

        private object _source;
        /// <summary>
        /// Returns the source of the argument.
        /// </summary>
        public object Source
        {
            get
            {
                return _source;
            }
            private set
            {
                _source = value;
            }
        }

        private object _target;
        /// <summary>
        /// Returns the target of this argument.
        /// </summary>
        public object Target
        {
            get
            {
                return _target;
            }
            private set
            {
                _target = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_source">The source of this arugment.</param>
        /// <param name="_target">The target of this argument.</param>
        public GameEventArgument(object _source, object _target)
        {
            Source = _source;
            Target = _target;
        }
    }
}
