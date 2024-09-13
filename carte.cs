using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Carte
    {
        public int Val { get; }

        public Carte(int Val)
        {

            this.Val = Val;
        }
        public override string ToString()
        {
            return Val.ToString();
        }
    }
}
