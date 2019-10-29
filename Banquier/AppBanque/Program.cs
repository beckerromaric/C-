using System;
using Banquier;

namespace AppBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey choix;
            Random numCompte = new Random();
            int numeroCompte = numCompte.Next(100000000, 999999999);
            string nom = "";
            double solde = 0, debit = 0;
            Compte c = new Compte(numeroCompte, nom, solde, debit); 
            Banque bnp = new Banque();
            //bnp.Init();

            //bnp.LesComptes.Add(new Compte(12456, "Haddock", 1500, -600));
            //Compte toto = new Compte();
            //Ecran.AfficherBanque(bnp);
            Console.WriteLine("Bienvenue dans le programme banque");

            do
            {
                Console.WriteLine("Veuillez faire un choix");
                Console.WriteLine("[1] - Créer un compte\n" +
                                  "[2] - Afficher dernier compte crée\n" +
                                  "[3] - Afficher tout les comptes\n"+
                                  "[4] - Créditer un compte\n" +
                                  "[5] - Débiter un compte\n" +
                                  "[6] - Faire un virement\n" +
                                  "[7] - Comparer le solde de deux comptes\n" +
                                  "[8] - Afficher le compte avec le plus d'argent\n" +
                                  "[Q] - Pour quitter le programme\n");

                choix = Console.ReadKey().Key;

                switch (choix)
                {
                    case ConsoleKey.NumPad1:

                        Console.WriteLine("\nVeuillez saisir votre nom");
                        nom = Console.ReadLine();
                        Console.WriteLine("Veuillez saisir le montant que vous voulez déposer");
                        solde = double.Parse(Console.ReadLine());
                        Console.WriteLine("Veuillez saisir le découvert autorisé que vous souhaitez");
                        debit = double.Parse(Console.ReadLine());
                        c = new Compte(numeroCompte, nom, solde, debit);
                        bnp.LesComptes.Add(c);

                        Console.WriteLine("\nVous avez créer le compte :\n{0}",c + "\n");
                        break;

                    case ConsoleKey.NumPad2:
                        Console.WriteLine("\nVotre compte est :\n{0}", c);
                        break;

                    case ConsoleKey.NumPad3:
                        Ecran.AfficherBanque(bnp);

                        break;

                    case ConsoleKey.NumPad4:

                        break;

                    case ConsoleKey.NumPad5:

                        break;

                    case ConsoleKey.NumPad6:

                        break;

                    case ConsoleKey.NumPad7:

                        break;

                    case ConsoleKey.NumPad8:

                        break;

                    case ConsoleKey.Escape:

                        break;
                }
            } while (ConsoleKey.Q != choix);
        }
    }
}
