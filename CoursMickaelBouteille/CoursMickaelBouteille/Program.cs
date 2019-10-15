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
            string ouvertFerme = "fermée";
            //débugger F11 pour étape suivante
            Console.WriteLine("Programme bouteille");

            number = SaisieDouble("Quelle capacité souhaitez-vous ?");

            bottle = new Bottle(number);

            do
            {
                Console.WriteLine("Quelle opération souhaitez vous effectuer ? ");
                Console.WriteLine("1: Ouvrir (O)");
                Console.WriteLine("2: Fermer (F)");
                Console.WriteLine("3: Remplir totalement la bouteille (R)");
                Console.WriteLine("4: Vider totalement la bouteille (V)");
                Console.WriteLine("5: Remplir partiellement la bouteille (+)");
                Console.WriteLine("6: Vider partiellement la bouteille (-)");
                Console.WriteLine("7: Quitter le programme (Q)");

                inputKey = Console.ReadKey().Key;

                switch (inputKey)
                {
                    case ConsoleKey.O:
                        
                        ouvertFerme = bottle.Open() ? "ouverte" : "fermée";
                        Console.WriteLine("\n\nLa bouteille est " + ouvertFerme);
                        break;

                    case ConsoleKey.F:
                        ouvertFerme = bottle.Close() ? "ouverte" : "fermée";
                        Console.WriteLine("\n\nLa bouteille est " + ouvertFerme + "\n");
                        break;

                    case ConsoleKey.R:
                        if (ouvertFerme == "ouverte")
                        {
                            bottle.Fill();
                            Console.WriteLine("\nLa bouteille est remplie, elle contient: " + bottle.GetCurrentVolume() + "L\n");
                        }
                        else
                        {
                            Console.WriteLine("\nLa bouteille est fermée !!");
                        }           
                        break;

                    case ConsoleKey.V:
                        if(ouvertFerme == "fermée")
                        {
                            Console.WriteLine("\nLa bouteille est fermée !!\n");
                        }
                        else
                        {
                            bottle.Empty();
                            Console.WriteLine("\nLa bouteille est vide, elle contient maintenant {0}L\n", bottle.GetCurrentVolume());
                        }
                        break;

                    case ConsoleKey.Add:
                       
                        if(ouvertFerme == "ouverte")
                        {
                            number = SaisieDouble("De combien de L voulez vous remplir la bouteille ?");
                            bottle.Fill(number);
                            Console.WriteLine("\nLa bouteille contient maintenant " + bottle.GetCurrentVolume() + "L\n");
                        }
                        else
                        {
                            Console.WriteLine("\nLa bouteille est fermée !!");
                        }          
                        break;

                    case ConsoleKey.Subtract:

                        if(ouvertFerme == "ouverte")
                        {
                            number = SaisieDouble("De combien de L voulez vous vider la bouteille ?");
                            bottle.Empty(number);
                            Console.WriteLine("\nLa bouteille contient maintenant " + bottle.GetCurrentVolume() + "L\n");
                        }
                        else
                        {
                            Console.WriteLine("La bouteille est fermée !!");
                        }
                        
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
