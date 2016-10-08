using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public class Hand
    {
        private List<Card> _cards = new List<Card>();

        public void Discard()
        {
            _cards.RemoveAt();
        }
    }
}
