using System;
using System.Linq;
using JeuDu421;
namespace App421Test
{
    class Program
    {
        public static bool IsNumeric(string _verif) => _verif.All(Char.IsDigit);

        public static bool IsNumeric(string _verif)
        {
            if (_verif.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int selectionManche;
            string selectDe2 = "", choix, selectDe;
            Partie maPartie = new Partie(1);
            Lancer monLancer = new Lancer();
            ConsoleKey saisie = new ConsoleKey();

            Console.WriteLine("Bienvenue dans le jeu 4-2-1");
            Console.WriteLine("Veuillez choisir le nombre de manche que vous souhaitez:");
            selectionManche = int.Parse(Console.ReadLine());
            maPartie = new Partie(selectionManche);

            Console.WriteLine("Vous avez choisis de faire une partie de {0} manches de 3 lancés chacuns, vous débutez avec {1} points", selectionManche, maPartie.NbPoints);
            maPartie.NouveauLancer();
            if (monLancer.EstGagnant())
            {
                Console.WriteLine("Bravo vous avez gagné !");
            }
         
            //maPartie.NbrLancer--;
              Console.WriteLine("Voici le premier tirage: ");
              Ecran.Afficher(monLancer);
            do
            { 
                do
                {

                    Console.WriteLine("Pour faire votre choix utilisez le pad numérique.");
                   
                    Console.WriteLine("[2] - Relancer tout les dés.");
                    Console.WriteLine("[3] - Relancer des dés au choix.");

                    saisie = Console.ReadKey().Key;


                    switch (saisie)
                    {
                        case ConsoleKey.NumPad1:

                            break;

                        case ConsoleKey.NumPad2:
                            Console.WriteLine("Relance des dés :");

                            monLancer.LancerUnDe(3);
                            Ecran.Afficher(monLancer);
                            maPartie.NbrLancer--;
                            
                            if (monLancer.EstGagnant())
                            {
                                Console.WriteLine("Bravo ! Vous avez gagné !");
                            }

                            break;
                        case ConsoleKey.NumPad3:
                            do
                            {
                                Console.WriteLine("Quel dé voulez vous relancer ?");
                                selectDe = Console.ReadLine();
                            } while (!IsNumeric(selectDe));

                            do
                            {
                                if (IsNumeric(selectDe))
                                {
                                    monLancer.LancerUnDe(int.Parse(selectDe));
                                    Ecran.Afficher(monLancer);

                                    Console.WriteLine("Voulez vous en lancer un autre ? (N pour annuler, sinon le numéro du dé)");
                                    selectDe2 = Console.ReadLine();

                                    if (IsNumeric(selectDe2))
                                    {
                                        monLancer.LancerUnDe(int.Parse(selectDe2));
                                        Ecran.Afficher(monLancer);
                                        maPartie.NbrLancer--;
                                        break;
                                    }
                                    maPartie.NbrLancer--;
                                }
                            } while (IsNumeric(selectDe2));

                            if (monLancer.EstGagnant())
                            {
                                Console.WriteLine("Bravo ! Vous avez gagner !");
                                break;
                            }

                            break;

                        case ConsoleKey.NumPad4:

                            break;
                    }
                } while (maPartie.NbrLancer != 0 /*|| maPartie.EstPerdue()*/);

                if (maPartie.NbrLancer == 0)
                {
                    Console.WriteLine("Nombre de lancé épuisé pour cette manche, début d'une nouvelle manche");
                    maPartie.NouveauLancer();
                    maPartie.MajPoints();
                    Console.WriteLine("Vous avez actuellement {0} points", maPartie.NbPoints);
                    Console.WriteLine("Voici le premier tirage: ");
                    Ecran.Afficher(monLancer);
                    //maPartie.NbrLancer--;
                }
            } while (ConsoleKey.Escape != saisie && maPartie.EstPerdue());

            Console.WriteLine("Vous n'avez plus de points vous avez donc perdu, rententez votre chance!");
            
            Console.ReadLine();
            //Ecran.Run();

        }
    }
}
