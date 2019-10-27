using System;

namespace TpComptesBancaires
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compte compte = new Compte();
            //Compte compte1 = new Compte(0000001, "Romaric", 1000, -500);
            //try
            //{
            //    Console.WriteLine(compte.Afficher());
            //    Console.WriteLine(compte1.Afficher());

            //    compte1.Crediter(2000);
            //    Console.WriteLine(compte1.Afficher());


            //    compte1.Debiter(5000);
            //    Console.WriteLine(compte1.Afficher());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //-----------------------------------------------------------------------------------------------

            //Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            //Compte compte2 = new Compte(45678, "Roro", 2000, -1000);
            //try
            //{

            //    //Cas Normal
            //    compte1.Transferer(1300, compte2);
            //    Console.WriteLine(compte1.Afficher());
            //    Console.WriteLine(compte2.Afficher());

            //    //Exception pour négatif
            //    //compte1.Transferer(-1000, compte2);
            //    //Console.WriteLine(compte1.Afficher());
            //    //Console.WriteLine(compte2.Afficher());

            //    //Exeception pour découvert autorisé
            //    compte1.Transferer(1000, compte2);
            //    Console.WriteLine(compte1.Afficher());
            //    Console.WriteLine(compte2.Afficher());
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            ////------------------------------------------------------------------------------------------------

            Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            Compte compte2 = new Compte(45678, "Roro", 2000, -1000);

            compte1.Transferer(1000, compte2);

            Console.WriteLine(compte1.Afficher());
            Console.WriteLine(compte2.Afficher());
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

            //Banque banque = new Banque();

            //banque.Init();
            //banque.AjouterCompte(12457, "Lolo", 4500, -500);
            ////Console.WriteLine(banque.AfficherComptes());

            //Console.WriteLine(banque.CompteSuperieur().Afficher());



            //Compte c = banque.CheckCompte(12657);


            //if (c != null)
            //{
            //    Console.WriteLine(c.Afficher());
            //}
            //else
            //{
            //    Console.WriteLine("Compte inexistant");
            //}

            //-------------------------------------------------------------------------------------------------------------
            //Banque banque1 = new Banque();
            //banque1.Init();

            //Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            //Compte compte2 = new Compte(45678, "Roro", 2000, -1000);


            //Console.WriteLine(compte1.Afficher());
            //Console.WriteLine(compte2.Afficher());
            //try
            //{
            //    if (banque1.Transferer(compte1, compte2, 1000))
            //    {
            //        Console.WriteLine("Transfert effectué");
            //        Console.WriteLine(compte1.Afficher());
            //        Console.WriteLine(compte2.Afficher());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Transfert impossible");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //--------------------------------------------------------------------
            //BanqueList banque2 = new BanqueList();
            //banque2.Init();

            //Console.WriteLine(banque2.AfficherCompte());

            //banque2.AjouterComptes(12546, "Koko", 4500, -500);

            //Console.WriteLine(banque2.AfficherCompte());
            //------------------------------------------------------

            //BanqueList banque2 = new BanqueList();
            //banque2.Init();

            //Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            //Compte compte2 = new Compte(45678, "Roro", 2000, -1000);

            //Console.WriteLine(compte1.Afficher());
            //Console.WriteLine(compte2.Afficher());
            //try
            //{

            //    if (banque2.Transferer(compte1, compte2, -10))
            //    {
            //        Console.WriteLine("Transfert effectué");
            //        Console.WriteLine(compte1.Afficher());
            //        Console.WriteLine(compte2.Afficher());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Transfert impossible");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //---------------------------------------------------------
            //BanqueList banque2 = new BanqueList();
            //banque2.Init();

            //Compte c = banque2.CheckCompte(12345);


            //if (c != null)
            //{
            //    Console.WriteLine(c.Afficher());
            //}
            //else
            //{
            //    Console.WriteLine("Compte inexistant");
            //}
        }
    }
}
