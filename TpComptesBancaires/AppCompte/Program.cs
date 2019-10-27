using System;
using Banquier;

namespace AppCompte
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte tech = new Compte();
            Compte toto = new Compte(5132645495654895, "Toto", 4000, -500);

            //Console.WriteLine(tech.AfficherCompte());
            //Console.WriteLine(toto.AfficherCompte());

            ////toto.Crediter(1200);

            ////Console.WriteLine(toto.AfficherCompte());

            ////toto.Debiter(6500);

            ////Console.WriteLine(toto.AfficherCompte());

            //toto.Transferer(tech, 1200);
            //Console.WriteLine(toto.AfficherCompte());
            //Console.WriteLine(tech.AfficherCompte());

            if (toto.Superieur(tech))
            {
                Console.WriteLine("Superieur");
            }
            else
            {
                Console.WriteLine("Inférieur");
            }

            Banque cmdp = new Banque();
            cmdp.Init();
            //Console.WriteLine(cmdp.AfficherCompte());
            //cmdp.AjouterCompter(5134654521543265, "Dutronc", 4500, -500);

            //Console.WriteLine(cmdp.AfficherCompte()); 

            Console.WriteLine(cmdp.CompteSup().AfficherCompte()); 
        }
    }
}
