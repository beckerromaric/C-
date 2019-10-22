using System;

namespace TpComptesBancaires
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compte compte = new Compte();
            //Compte compte1 = new Compte(0000001, "Romaric", 1000, -500);

            //Console.WriteLine(compte.Afficher());
            //Console.WriteLine(compte1.Afficher());

            //compte1.Crediter(2000);
            //compte1.Debiter(5000);

            //Console.WriteLine(compte1.Afficher());
            //-----------------------------------------------------------------------------------------------

            //Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            //Compte compte2 = new Compte(45678, "Roro", 2000, -1000);

            //compte1.Transferer(1300, compte2);

            //Console.WriteLine(compte1.Afficher());
            //Console.WriteLine(compte2.Afficher());
            //------------------------------------------------------------------------------------------------

            //Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            //Compte compte2 = new Compte(45678, "Roro", 2000, -1000);

            //compte1.Transferer(3300, compte2);

            //Console.WriteLine(compte1.Afficher());
            //Console.WriteLine(compte2.Afficher());
            //-------------------------------------------------------------------------------------------------

            //Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            //Compte compte2 = new Compte(45678, "Roro", 2000, -1000);
            //if (compte1.Superieur(compte2))
            //{
            //    Console.WriteLine("supérieur");
            //}
            //else
            //{
            //    Console.WriteLine("inférieur");
            //}
            //----------------------------------------------------------------------------------

            //Banque banque1 = new Banque();
            //banque1.Init();

            //Console.WriteLine(banque1.AfficherComptes());
            //-----------------------------------------------------------------------------------------------------

            Banque banque = new Banque();

            banque.Init();
            banque.AjouterCompte(12457, "Lolo", 4500, -500);
            Console.WriteLine(banque.AfficherComptes());

            //Console.WriteLine(banque.CompteSuperieur());

            //cas positif
            //Console.WriteLine(banque.CheckCompte(12457));
            //cas négatif
            //Console.WriteLine(banque.CheckCompte(12557));

            Compte c = banque.CheckCompte(12457);

            if (c != null)
            {
                c.Afficher();
            }
        }
    }
}
