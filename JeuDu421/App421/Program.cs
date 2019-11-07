using System;
using JeuDu421;

namespace App421
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectionManche, selectDe;
            Partie maPartie;
            Lancer monLancer = new Lancer();
            ConsoleKey saisie = new ConsoleKey();

            Console.WriteLine("Bienvenue dans le jeu 4-2-1");

            Console.WriteLine("Veuillez choisir le nombre de manche que vous souhaitez:");
            selectionManche = int.Parse(Console.ReadLine());

            maPartie = new Partie(selectionManche);

            Console.WriteLine("Vous avez choisis de faire une partie de {0} manches de 3 lancés chacuns, vous débutez avec {1} points", selectionManche, maPartie.NbPoints);
            maPartie.NouveauLancer();
            Console.WriteLine("Voici le premier tirage: ");
            Ecran.Afficher(monLancer);

            Console.WriteLine("Quel dé voulez vous relancer ?");
            selectDe = int.Parse(Console.ReadLine());

            Console.WriteLine("Voulez vous en lancer un autre ?");
            monLancer.LancerUnDe(selectDe);

            switch (saisie)
            {
                case ConsoleKey.Oem1

                    break;
            }




            Console.ReadLine();
            //Ecran.Run();

        }
    }
}
