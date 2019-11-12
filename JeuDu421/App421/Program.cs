using System;
using System.Linq;
using JeuDu421;

namespace App421
{
    class Program
    {
        public static bool IsNumeric(string _verif) => _verif.All(Char.IsDigit);

        static void Main(string[] args)
        {
            int selectionManche;
            string selectDe;//, choix, selectDe2;
            Partie maPartie = new Partie(1);
            Lancer monLancer = new Lancer();
            ConsoleKey saisie = new ConsoleKey();




            Console.WriteLine("Bienvenue dans le jeu 4-2-1");
            Console.WriteLine("Veuillez choisir le nombre de manche que vous souhaitez:");
            selectionManche = int.Parse(Console.ReadLine());
            maPartie = new Partie(selectionManche);

            Console.WriteLine("Vous avez choisis de faire une partie de {0} manches de 3 lancés chacuns, vous débutez avec {1} points", selectionManche, maPartie.NbPoints);
            maPartie.NouveauLancer();
            Ecran.Afficher(maPartie.MonLancerCourant);
            if (monLancer.EstGagnant())
            {
                Console.WriteLine("Bravo! Vous avez gagner.");
            }
            maPartie.NbManche--;

            do
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Combien de dé voulez vous relancer ?");
                        selectDe = Console.ReadLine();
                    }
                    while (!IsNumeric(selectDe));

                    Ecran.Recommencer(maPartie, int.Parse(selectDe));
                    Ecran.Afficher(maPartie.MonLancerCourant);
                    maPartie.NbManche--;
                    if (monLancer.EstGagnant())
                    {
                        Console.WriteLine("Bravo! Vous avez gagner");
                    }





                } while (maPartie.NbrLancer != 3);

            } while (!maPartie.EstPerdue() && maPartie.NbManche <= selectionManche);


            Console.ReadLine();


        }
    }
}
