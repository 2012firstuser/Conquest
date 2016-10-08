using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conquest
{
    public static class DeckManager
    {
        private static List<Deck> _decks = new List<Deck>()
        {

        };

        public static Deck GetDeck()
        {
            return null;
        }

        public static void AddDeck(Deck deck)
        {
            _decks.Add(deck);
        }

        public static void RemoveDeck(Deck deck)
        {
            _decks.Remove(deck);
        }
    }
}
