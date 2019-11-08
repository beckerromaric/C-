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
    }
}
