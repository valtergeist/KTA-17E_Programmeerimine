using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Class_Deck
    {
        private Card[] cards;

        public Array Deck()
        {
            var query =
                from suit in new[] { "Spades", "Hearts", "Clubs", "Diamonds", }
                from rank in Enumerable.Range(1, 13)
                select new Card(rank, suit);

            cards = query.ToArray();
            return;
        }
    }
}
