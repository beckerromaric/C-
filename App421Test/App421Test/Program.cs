using System;
using System.Linq;
using JeuDu421;
namespace App421Test
{
    class Program
    {
        public static bool IsNumeric(string _verif) => _verif.All(Char.IsDigit);

        //public static bool IsNumeric(string _verif)
        //{
        //    if (_verif.All(char.IsDigit))
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        static void Main(string[] args)
        {
            int manche;
            string selectDe2 = "", /*choix,*/ selectDe, selectionManche;
            Partie maPartie = new Partie(1);
            Lancer monLancer = new Lancer();
            ConsoleKey saisie = new ConsoleKey();
            bool verif = false;

            Console.WriteLine("Bienvenue dans le jeu 4-2-1");
            do
            {
                Console.WriteLine("Veuillez choisir le nombre de manches que vous souhaitez jouer:");
                selectionManche = Console.ReadLine();
                if (IsNumeric(selectionManche))
                {
                    manche = int.Parse(selectionManche);
                    maPartie = new Partie(manche);
                    verif = true;
                }
                else
                {
                    Console.WriteLine("Veuillez saisir un nombre svp !\n");
                }
            } while (!IsNumeric(selectionManche));


            Console.WriteLine("Vous avez choisis de faire une partie de {0} manches de 3 lancés chacuns, vous débutez avec {1} points", selectionManche, maPartie.NbPoints);

            do
            {
                maPartie.NouveauLancer();
                Console.WriteLine("");
                maPartie.MonLancerCourant.Trier();
                maPartie.NbrLancer--;

                if (maPartie.MonLancerCourant.EstGagnant())
                {
                    maPartie.MajPoints();
                    Console.WriteLine("Bravo vous avez gagné !");
                }

                if (!verif)
                {
                    Console.WriteLine("Nombre de lancé épuisé pour cette manche, début d'une nouvelle manche");
                    Console.WriteLine("\nVous avez actuellement {0} points", maPartie.NbPoints);
                    Console.WriteLine("\nVoici le premier tirage: ");
                    Ecran.Afficher(maPartie.MonLancerCourant);
                }
                else
                {
                    Console.WriteLine("Voici le premier tirage:");
                    Ecran.Afficher(maPartie.MonLancerCourant);
                }

                do
                {
                    verif = false;
                    Console.WriteLine("Pour faire votre choix utilisez le pad numérique.");

                    Console.WriteLine("[1] - Relancer un dé.");
                    Console.WriteLine("[2] - Relancer deux dés.");
                    Console.WriteLine("[3] - Relancer tout les dés.");
                    Console.WriteLine("[4] - Affichage du score.");
                    Console.WriteLine("[5] - Affichage du nombre d'essai restant pour cette manche.");
                    Console.WriteLine("[6] - Affichage du dernier lancé.");

                    saisie = Console.ReadKey().Key;


                    switch (saisie)
                    {
                        case ConsoleKey.NumPad1:
                            do
                            {
                                Console.WriteLine("\nQuel dé voulez vous relancer ?");
                                selectDe = Console.ReadLine();
                            }
                            while (!IsNumeric(selectDe));

                            maPartie.Lancer1(int.Parse(selectDe));
                            Ecran.Afficher(maPartie.MonLancerCourant);
                            break;

                        case ConsoleKey.NumPad2:
                            do
                            {
                                Console.WriteLine("\nQuel dé voulez vous relancer ?");
                                selectDe = Console.ReadLine();
                                Console.WriteLine("Quel est le deuxieme dé que vous voulez relancer?");
                                selectDe2 = Console.ReadLine();
                            } while (!IsNumeric(selectDe) && !IsNumeric(selectDe2) && selectDe == null);


                            if (IsNumeric(selectDe) && IsNumeric(selectDe2) && selectDe != null)
                            {
                                maPartie.Lancer2(int.Parse(selectDe), int.Parse(selectDe2));
                                Ecran.Afficher(maPartie.MonLancerCourant);

                            }
                            if (maPartie.MonLancerCourant.EstGagnant())
                            {
                                maPartie.MajPoints();
                                Console.WriteLine("Bravo ! Vous avez gagner !");
                                break;
                            }

                            break;

                        case ConsoleKey.NumPad3:

                            Console.WriteLine("\nRelance des dés :");

                            maPartie.Lancer3();
                            Ecran.Afficher(maPartie.MonLancerCourant);

                            if (monLancer.EstGagnant())
                            {
                                Console.WriteLine("Bravo ! Vous avez gagné !");
                            }
                            break;

                        case ConsoleKey.NumPad4:
                            Console.WriteLine("\nVous avez actuellement {0} points.\n", maPartie.NbPoints);
                            break;

                        case ConsoleKey.NumPad5:
                            if(maPartie.NbrLancer == 1)
                            {
                                Console.WriteLine("\nIl vous reste {0} lancé.\n", maPartie.NbrLancer);
                            }
                            else
                            {
                                Console.WriteLine("\nIl vous reste {0} lancés.\n", maPartie.NbrLancer);
                            }
                            break;
                        case ConsoleKey.NumPad6:

                            Console.WriteLine("\nVoici votre dernier lancé: ");
                            Ecran.Afficher(maPartie.MonLancerCourant);
                            break;
                    }
                } while (maPartie.NbrLancer != 0 && saisie != ConsoleKey.Escape && !maPartie.MonLancerCourant.EstGagnant());

                if (monLancer.EstGagnant())
                {
                    maPartie.MajPoints();
                    Console.WriteLine("Bravo ! Vous avez gagné !");
                }
                else
                {
                    maPartie.MajPoints();
                }

            } while (saisie != ConsoleKey.Escape && maPartie.EstPerdue());

            if (saisie == ConsoleKey.Escape)
            {
                Console.WriteLine("\nVous avez décider de quitter le jeu, à bientôt");
            }
            else
            {
                int manches = (int.Parse(selectionManche) - maPartie.NbManche);
                Console.WriteLine("Vous n'avez plus de points vous avez donc perdu, rententez votre chance!");
                Console.WriteLine("Vous avez disputé {0} manches et votre score final est de {1}", manches, maPartie.NbPoints);
            }


            Console.ReadLine();
            //Ecran.Run();

        }
    }
}
