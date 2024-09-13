using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Dealer : Joueur
    {
        public Dealer() : base() { }


        public override Main Deal(Deck deck)
        {

            while (main.Total() < 17)
            {
                CartesDeal(1, deck);


         
            }
            return main;
        }
    }
}
