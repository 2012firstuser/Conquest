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

        /// <summary>
        /// Called when a random card needs to be discarded.
        /// </summary>
        public void DiscardRandom()
        {
            DiscardCard(_cards[Util.Random.Next() * _cards.Count]);
        }

        /// <summary>
        /// Called when a specific card is discarded.
        /// </summary>
        /// <param name="card"></param>
        public void DiscardCard(Card card)
        {
            card.Discard();
            _cards.Remove(card);
        }

        /// <summary>
        /// Called when a player plays a card from their hand.
        /// </summary>
        /// <param name="card"></param>
        public void PlayCard(Card card)
        {
            card.Play();
            DiscardCard(card);
        }
    }
}
