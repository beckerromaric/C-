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
            string ouvertFerme = "fermée";
            double resultat;
            //débugger F11 pour étape suivante
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine("Programme bouteille");
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-\n");
            number = SaisieDouble("Quelle capacité souhaitez-vous ?\n");

            bottle = new Bottle(number);

            do
            {
                Console.WriteLine("\nQuelle opération souhaitez vous effectuer ? ");
                Console.WriteLine("1: Ouvrir (O)");
                Console.WriteLine("2: Fermer (F)");
                Console.WriteLine("3: Remplir la bouteille (R)");
                Console.WriteLine("4: Vider la bouteille (V)");
                Console.WriteLine("5: Remplir partiellement la bouteille (+)");
                Console.WriteLine("6: Vider partiellement la bouteille (-)");
                Console.WriteLine("7: Quitter le programme (Q)");

                inputKey = Console.ReadKey().Key;

                switch (inputKey)
                {
                    case ConsoleKey.O:             
                        ouvertFerme = bottle.Open() ? "ouverte" : "fermée";
                        Console.WriteLine("\n\nLa bouteille est " + ouvertFerme + "\n");
                        break;

                    case ConsoleKey.F:
                        ouvertFerme = bottle.Close() ? "ouverte" : "fermée";
                        Console.WriteLine("\n\nLa bouteille est " + ouvertFerme + "\n");
                        break;

                    case ConsoleKey.R:
                        if(ouvertFerme == "ouverte")
                        {
                            bottle.Fill();
                            Console.WriteLine("\nLa bouteille est remplie! Elle contient {0}L\n", bottle.Fill());
                        }
                        else
                        {
                            
                            Console.WriteLine("\nVous ne pouvez pas remplir la bouteille car elle est fermée !!\n");
                        }
                        break;

                    case ConsoleKey.V:
                        if(ouvertFerme == "fermée")
                        {
                            Console.WriteLine("\nLa bouteille est fermée vous ne pouvez pas la vider !\n");
                        }
                        else
                        {
                            bottle.Empty();
                            Console.WriteLine("\nLa bouteille est vide! Elle contient maintenant {0}\n", bottle.Empty());
                        }
                        break;

                    case ConsoleKey.OemPlus:
                        if (ouvertFerme == "ouverte")
                        {
                            resultat = SaisieDouble("\nDe combien de cl voulez remplir la bouteille ?\n");
                            resultat = bottle.Fill(resultat);
                            if (resultat < bottle.GetCapacity())
                            {
                                
                                Console.WriteLine("\nLa bouteille contient désormais " + resultat + "L");
                            }
                            else
                            {
                                Console.WriteLine("\nVous ne pouvez pas remplir la bouteille car vous dépassez la capacité !!\n");    
                            }                           
                        }
                        else
                        {
                            Console.WriteLine("\nVous ne pouvez pas remplir la bouteille car elle est fermée !!\n");
                        }
                        break;

                    case ConsoleKey.Subtract:
                        if (ouvertFerme == "ouverte")
                        {
                            resultat = SaisieDouble("\nDe combien de cl voulez vous vider la bouteille ?\n");
                            resultat = bottle.Empty(resultat);

                            if(resultat > bottle.GetCapacity())
                            {
                                Console.WriteLine("\nLa bouteille contient désormais " + resultat + "L\n");
                            }
                            else
                            {
                                Console.WriteLine("Vous essayez de vider plus que possible, remise a {0}", resultat);
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("\nVous ne pouvez pas vider la bouteille car elle est fermée !!\n");
                        }
                        
                        
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
