using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursMickaelPerso
{
    class Program
    {
        static double SaisieDouble(string _message)
        {
            string saisie;
            double number;

            do
            {
                Console.WriteLine(_message);
                saisie = Console.ReadLine();
            }
            while (!double.TryParse(saisie, out number));

            return number;
        }

        static void Main(string[] args)
        {

            double number;
            Bottle bottle;
            ConsoleKey inputKey;
            string ouvertFerme;
            double resultat;
            //débugger F11 pour étape suivante
            Console.WriteLine("Programme bouteille");

            number = SaisieDouble("Quelle capacité souhaitez-vous ?");

            bottle = new Bottle(number);

            do
            {
                Console.WriteLine("\nQuelle opération souhaitez vous effectuer ? ");
                Console.WriteLine("1: Ouvrir (O)");
                Console.WriteLine("2: Fermer (F)");
                Console.WriteLine("3: Remplir la bouteille (R)");
                Console.WriteLine("4: Vider la bouteille (V)");
                Console.WriteLine("5: Remplir totalement la bouteille (+)");
                Console.WriteLine("6: Vider totalement la bouteille (-)");
                Console.WriteLine("7: Quitter le programme (Q)");

                inputKey = Console.ReadKey().Key;

                switch (inputKey)
                {
                    case ConsoleKey.O:

                        ouvertFerme = bottle.Open() ? "ouverte\n" : "fermée\n";
                        Console.WriteLine("\n\nLa bouteille est " + ouvertFerme);
                        break;

                    case ConsoleKey.F:
                        ouvertFerme = bottle.Close() ? "ouverte\n" : "fermée\n";
                        Console.WriteLine("\n\nLa bouteille est " + ouvertFerme);
                        break;

                    case ConsoleKey.R:
                        bottle.Fill();
                        Console.WriteLine("\nLa bouteille est remplie! Elle contient {0}L\n", bottle.Fill());
                        break;

                    case ConsoleKey.V:
                        bottle.Empty();
                        Console.WriteLine("\nLa bouteille est vide! Elle contient maintenant {0}\n", bottle.Empty());
                        break;

                    case ConsoleKey.OemPlus:
                        resultat = SaisieDouble("\nDe combien de cl voulez remplir la bouteille ?\n");
                        bottle.Fill(resultat);
                        Console.WriteLine("\nLa bouteille contient désormais " + bottle.Fill(resultat) + "L");
                        break;

                    case ConsoleKey.Subtract:
                        resultat = SaisieDouble("\nDe combien de cl voulez vous vider la bouteille ?\n");
                        bottle.Empty(resultat);
                        Console.WriteLine("\nLa bouteille contient désormais "+ bottle.Empty(resultat) + "L\n");
                        break;

                    case ConsoleKey.Q:

                        break;
                }
            }
            while (ConsoleKey.Q != inputKey);

            Console.WriteLine("\nBye !");

            Console.ReadLine();
        }
    }
}
