using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
     class Jeu
    {
        Deck deck;
        public Jeu() { 
        deck = new Deck();
        }

        public void Jouer()
        {
            Joueur joueur = new Joueur();

           Main mainjoueur = joueur.Deal(deck);

            if (mainjoueur.IsBusted())
            {
                Console.WriteLine("T'as beaucoup trop de cartes , n'oublie pas 21 cartes est le maximum au blackjack");
                Console.WriteLine("Tu as Perdu");
                return;
            }
            else
            {
                Console.WriteLine("Le joueur reste à  {0}", mainjoueur.Total());
            }

            Console.WriteLine();
            Console.WriteLine("Le dealer joue");

            Dealer dealer = new Dealer();
            Main maindealer = dealer.Deal(deck);

            Console.WriteLine();
            if (maindealer.IsBusted())
            {
                Console.Write("Le dealer à perdu!");
                Console.WriteLine();
                Console.WriteLine("Bien joué vous avez gagné!");
                return;
            }
            Console.WriteLine();
            if (mainjoueur.Total() > maindealer.Total())
            {
                Console.WriteLine("Le joueur a {0} cartes, qui gagne donc le dealeur qui a {1} cartes", mainjoueur.Total(), maindealer.Total());
                Console.WriteLine("Le joueur gagne!");
            }
            else
            {
                Console.WriteLine("Le dealeur a {1} cartes, qui gagne donc le joueur qui a {0} cartes", mainjoueur.Total(), maindealer.Total());
                Console.WriteLine("Perdu!");
            }

        }


    }
}
