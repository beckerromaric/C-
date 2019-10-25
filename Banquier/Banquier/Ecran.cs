using System;
using System.Collections.Generic;
using System.Text;

namespace Banquier
{
    public class Ecran
    {
        public static void AfficherCompte(Compte _compte)
        {
            string description = _compte.Afficher();

            Console.WriteLine(description);
        }

        public static void AfficherBanque(Banque _banque)
        {
            Console.WriteLine("---------Affichage banque---------\n");
            foreach (var unCompte in _banque.LesComptes)
            {
                Console.WriteLine("----------Début de compte---------\n");
                AfficherCompte(unCompte);
                Console.WriteLine("----------Fin de compte---------\n");
            }
            Console.WriteLine("\n---------Fin affichage banque---------\n");
        }


    }
}
