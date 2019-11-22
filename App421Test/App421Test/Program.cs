using System;
using System.Linq;
using JeuDu421;
using Microsoft.OData.Edm;

namespace App421Test
{
    class Program
    {
        //public static bool IsNumeric(string _verif) => _verif.All(Char.IsDigit);


        public static bool IsNumeric(string _verif)
        {
            if (_verif.All(char.IsDigit))
            {
                return true;
            }
            if (String.IsNullOrEmpty(_verif))
            {
                throw new Exception("Vous n'avez rien saisi!");
            }
            return false;
        }

        static void Main(string[] args)
        {
            int manche, tde1, tde2;
            string selectDe2, selectDe = "", selectionManche;
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
                    Console.WriteLine("[3] - Relancer tous les dés.");
                    Console.WriteLine("[4] - Affichage du score.");
                    Console.WriteLine("[5] - Affichage du nombre d'essai restant pour cette manche.");
                    Console.WriteLine("[6] - Affichage du dernier lancé.");
                    Console.WriteLine("[Echap] - Quitter l'application.");

                    saisie = Console.ReadKey().Key;


                    switch (saisie)
                    {
                        case ConsoleKey.NumPad1:
                            do
                            {
                                Console.WriteLine("\nQuel dé voulez vous relancer ?");
                                selectDe = Console.ReadLine();

                                int.TryParse(selectDe, out int r);
                                tde1 = r;

                                if (!IsNumeric(selectDe))
                                {
                                    Console.WriteLine("Veuillez saisir une valeur entre 1 et 3!");
                                }
                                else if (r == 0)
                                {
                                    Console.WriteLine("Veuillez faire une saisie correcte! 1, 2 ou 3.");
                                }
                            }
                            while ((tde1 >= 4 || tde1 <= 0));

                            maPartie.Lancer1(int.Parse(selectDe));
                            Console.WriteLine("\nAffichage du lancé:\n");
                            Ecran.Afficher(maPartie.MonLancerCourant);
                            break;

                        case ConsoleKey.NumPad2:
                            do
                            {   //A REVOIR
                                Console.WriteLine("\nQuel est le premier dé que voulez vous relancer ?");
                                selectDe = Console.ReadLine();
                                Console.WriteLine("Quel est le deuxieme dé que vous voulez relancer?");
                                selectDe2 = Console.ReadLine();
                                
                                int.TryParse(selectDe, out int r);
                                int.TryParse(selectDe2, out int d);
                                tde1 = r;
                                tde2 = d;
                                if(!IsNumeric(selectDe) || !IsNumeric(selectDe2))
                                {
                                    Console.WriteLine("Veuillez saisir un chiffre entre 1 et 3!");
                                }
                                else if ((tde1 >= 4 || tde1 <= 0) && (tde2 >= 4 || tde2 <= 0))
                                {
                                    Console.WriteLine("Le dé {0} et le dé {1} n'éxistent pas !", tde1, tde2);
                                }
                                else if (tde1 >= 4 || tde1 <= 0)
                                {
                                    Console.WriteLine("Le dé {0} n'existe pas !\n", tde1);
                                }
                                else if (tde2 >= 4 || tde2 <= 0)
                                {
                                    Console.WriteLine("Le dé {0} n'éxiste pas !", tde2);
                                }
                            } while ((tde1 >= 4 || tde1 <= 0) || (tde2 >= 4 || tde2 <= 0));



                            if ((tde1 <= 3 && tde1 >= 1) && (tde2 <= 3 && tde2 >= 1))
                            {
                                int de = int.Parse(selectDe);
                                int de1 = int.Parse(selectDe2);
                                maPartie.Lancer2(de, de1);
                                Console.WriteLine("Affichage du lancé:\n");
                                Ecran.Afficher(maPartie.MonLancerCourant);
                            }

                            if (maPartie.MonLancerCourant.EstGagnant())
                            {
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
                            if (maPartie.NbrLancer == 1)
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

            } while (saisie != ConsoleKey.Escape && maPartie.EstPerdue() /*&& maPartie.NbManche <= 0*/);

            if (saisie == ConsoleKey.Escape)
            {
                Console.WriteLine("\nVous avez décider de quitter le jeu, à bientôt");
            }
            else
            {
                int manches = (int.Parse(selectionManche) - maPartie.NbManche);
                Console.WriteLine("Vous n'avez plus de points vous avez donc perdu, rententez votre chance!");
                Console.WriteLine("Vous avez disputé {0} manches et votre score final est de {1} points", manches, maPartie.NbPoints);
            }


            Console.ReadLine();
            //Ecran.Run();

        }
    }
}
