using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursMickaelBouteille
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
            while(!double.TryParse(saisie, out number));

            return number;
        }

        static void Main(string[] args)
        {

            double number;
            Bottle bottle;
            ConsoleKey inputKey;
            string ouvertFerme;
            //débugger F11 pour étape suivante
            Console.WriteLine("Programme bouteille");

            number = SaisieDouble("Quelle capacité souhaitez-vous ?");

            bottle = new Bottle(number);

            do
            {
                Console.WriteLine("Quelle opération souhaitez vous effectuer ? ");
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
                        
                        break;

                    case ConsoleKey.V:

                        break;

                    case ConsoleKey.OemPlus:
                        Console.WriteLine("Reussi +");
                        break;

                    case ConsoleKey.Subtract:
                        Console.WriteLine("Reussi! - ");
                        break;

                    case ConsoleKey.Q:

                        break;
                }
            }
            while (ConsoleKey.Q != inputKey);

            Console.WriteLine("\nBye !");

            Console.ReadLine();


            Bottle bouteille = new Bottle(2);

            //Console.WriteLine("Etat bouteille" + bouteille.Open());
            Console.WriteLine("Etat bouteille" + bouteille.Close());

            Console.WriteLine("Remplissage bouteille son volume est : ");
            Console.WriteLine(bouteille.Fill(0.5d));

            Console.WriteLine("Vidage bouteille son volume est : ");
            Console.WriteLine(bouteille.Empty(-5));




            Console.ReadLine();
        }
    }
}
