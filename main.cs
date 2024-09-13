using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Main
    {
        ArrayList cartes;
        public Main()
        {       
            cartes = new ArrayList();
        }

        public void AddCard(Carte carte)
        {
            cartes.Add(carte);
        }

        public bool IsBusted()
        {
            return this.Total() > 21;
        }

        public int Total()
        {
            int total = 0;
            foreach (Carte carte in cartes)
            {
                total += carte.Val;
            }
            return total;
        }
        public override string ToString()
        {
            string s = "Main: ";
            foreach (Carte carte in cartes)
            {
                s += carte + " ";
            }
            s += "\nTotal: ";
            s += Total();
            return s;
        }
    }
}