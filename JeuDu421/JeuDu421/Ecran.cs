using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDu421
{
    public class Ecran
    {
        //Pour la classe De
        public static void AfficherDe(De _de)
        {
            Console.WriteLine(_de.ValeurDe.ToString());
        }

        //Pour la classe Lancer

        public static void Afficher(Lancer _lancer)
        {

            for (int num = 1; num <= 3; num++)
            {
                Console.WriteLine(_lancer.GetValeurDe(num));
                Console.WriteLine();
            }
        }

        public static void Run()
        {
            Lancer lance = new Lancer();
            Afficher(lance);
            lance.LancerUnDe(1);
            Afficher(lance);
        }

        public static void Recommencer(Partie _unePartie, int _nbrDe)
        {
            if(_nbrDe == 3)
            {
                for (int i = 1; i <= 3; i++)
                {
                    _unePartie.MonLancerCourant.LancerUnDe(i);
                }
                _unePartie.MonLancerCourant.Trier();
            }
            else
            {
                for (int i = 0; i < _nbrDe; i++)
                {
                    if(_nbrDe == 1)
                    {
                        Console.WriteLine("Quel le " + i + "er dé que vous voulez rejouer ? 1, 2 ou 3 ?");

                    }
                    else
                    {
                        Console.WriteLine("Quel est le "+ i +"ieme dé que vous voulez rejouer? 1, 2 ou 3?");
                    }
                    int numDe = int.Parse(Console.ReadLine());
                    _unePartie.MonLancerCourant.LancerUnDe(numDe);
                }
                _unePartie.MonLancerCourant.Trier();
                //Ecran.Afficher(_unePartie.MonLancerCourant);
            }
        }
    }
}
