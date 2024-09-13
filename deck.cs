using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
     class Deck
    {
        Random random;

        public Deck() {
        random = new Random();
        }

        public Carte GetCarte()
        {
            int rang = random.Next(1, 11);
            Carte c = new Carte(rang);
            return c;
        }
    }
}
