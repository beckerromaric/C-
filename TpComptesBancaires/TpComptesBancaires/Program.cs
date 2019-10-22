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

            Compte compte1 = new Compte(12345, "Romaric", 1000, -500);
            Compte compte2 = new Compte(45678, "Roro", 2000, -1000);
            if (compte1.Superieur(compte2))
            {
                Console.WriteLine("supérieur");
            }
            else
            {
                Console.WriteLine("inférieur");
            }
        }
    }
}
