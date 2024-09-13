using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    internal class Joueur
    {
        protected Main main;

        public Joueur()
        {
            main = new Main();
        }

        public virtual Main Deal(Deck deck)
        {
            CartesDeal(2, deck);
            Console.WriteLine();

            bool playing = true;
            while (playing)
            {
                Console.Write("voulez vous Ajouter (A) ou Rester (R)?: ");
                string reponse = Console.ReadLine();
                switch (reponse.ToUpper())
                {
                    case "A":
                        CartesDeal(1, deck);
                        playing = !main.IsBusted();
                        break;
                    case "R":
                        playing = false;
                        break;
                    default:
                        Console.WriteLine("Touche invalide");
                        break;
                }
            }

            return main;
        }

        public void CartesDeal(int num, Deck deck)
        {
            string carteString = (num == 1) ? "vos carte" : "vos cartes";
            Console.WriteLine("Voici " + carteString);
            for (int i = 0; i < num; i++)
            {
                main.AddCard(deck.GetCarte());
            }
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return main.ToString();
        }

    }

}

