using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public static class Util
    {
        private static Random _random = new Random();
        public static Random Random
        {
            get
            {
                return _random;
            }
        }
    }
}
