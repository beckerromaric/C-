using System;
using System.Linq;
using JeuDu421;

namespace App421
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
                    Console.WriteLine("Vous avez actuellement {0} points", maPartie.NbPoints);
                    Console.WriteLine("Voici le premier tirage: ");
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

                    Console.WriteLine("[1] - Relancer tout les dés.");
                    Console.WriteLine("[2] - Relancer des dés au choix.");
                    Console.WriteLine("[3] - Affichage de votre score.");
                    Console.WriteLine("[4] - Affichage du nombre d'essai restant pour cette manche.");

                    saisie = Console.ReadKey().Key;


                    switch (saisie)
                    {
                        case ConsoleKey.NumPad1:
                            Console.WriteLine("Relance des dés :");

                            maPartie.MonLancerCourant.LancerUnDe(3);
                            maPartie.MonLancerCourant.Trier();
                            Ecran.Afficher(maPartie.MonLancerCourant);
                            maPartie.NbrLancer--;

                            if (monLancer.EstGagnant())
                            {
                                maPartie.MajPoints();
                                Console.WriteLine("Bravo ! Vous avez gagné !");
                            }

                            break;
                        case ConsoleKey.NumPad2:
                            do
                            {
                                Console.WriteLine("Quel dé voulez vous relancer ?");
                                selectDe = Console.ReadLine();
                            } while (!IsNumeric(selectDe));


                            if (IsNumeric(selectDe))
                            {
                                maPartie.MonLancerCourant.LancerUnDe(int.Parse(selectDe));
                                maPartie.MonLancerCourant.Trier();
                                Ecran.Afficher(maPartie.MonLancerCourant);

                                Console.WriteLine("Voulez vous en lancer un autre ? (N pour annuler, sinon le numéro du dé)");
                                selectDe2 = Console.ReadLine();

                                if (IsNumeric(selectDe2))
                                {
                                    maPartie.MonLancerCourant.LancerUnDe(int.Parse(selectDe2));
                                    maPartie.MonLancerCourant.Trier();
                                    Ecran.Afficher(maPartie.MonLancerCourant);
                                    maPartie.NbrLancer--;
                                    break;
                                }
                                maPartie.NbrLancer--;
                            }
                            //} while (IsNumeric(selectDe2));

                            if (maPartie.MonLancerCourant.EstGagnant())
                            {
                                maPartie.MajPoints();
                                Console.WriteLine("Bravo ! Vous avez gagner !");
                                break;
                            }

                            break;

                        case ConsoleKey.NumPad3:
                            Console.WriteLine("\nVous avez actuellement {0} points.\n", maPartie.NbPoints);
                            break;

                        case ConsoleKey.NumPad4:
                            if (maPartie.NbrLancer == 1)
                            {
                                Console.WriteLine("\nIl vous reste {0} lancé.\n", maPartie.NbrLancer);
                            }
                            else
                            {
                                Console.WriteLine("\nIl vous reste {0} lancés.\n", maPartie.NbrLancer);
                            }
                            break;
                    }
                } while (maPartie.NbrLancer != 0 && saisie != ConsoleKey.Escape /*|| maPartie.EstPerdue()*/);

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
                Console.WriteLine("\n   Vous avez décider de quitter le jeu, à bientôt");
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
