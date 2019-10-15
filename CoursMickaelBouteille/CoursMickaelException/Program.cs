using System;

namespace CoursMickaelException
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
                //Bottle bottle1;
                ConsoleKey inputKey;
                string ouvertFerme = "fermée";
                //débugger F11 pour étape suivante
                Console.WriteLine("Programme bouteille");

                number = SaisieDouble("Quelle capacité souhaitez-vous ?");

                bottle = new Bottle(number);

            ////Exemple de try catch avec la methode Open
            //bottle1 = new Bottle(10);
            //try
            //{
            //    bottle1.Open();
            //    //bottle1.Open();
            //    bottle1.Close();
            //    bottle1.Close(); 
            //}   //L'exception est attrapée dans la variable e
            //catch(Exception e)
            //{
            //    Console.WriteLine("Erreur" + e.Message);
            //    Console.WriteLine("Erreur" + e.StackTrace);
            //    Console.WriteLine("Erreur" + e.Message);
            //}

            //Pour récuperer directement l'appui de la touche sans appui sur 
            //la touche entrée

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;
            Console.WriteLine("Vous avez appuyé sur la touche: {0}", key.ToString());



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
                    try
                    {

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

                                bottle.Fill();
                                Console.WriteLine("\nLa bouteille est remplie, elle contient: " + bottle.GetCurrentVolume() + "L\n");

                            break;

                            case ConsoleKey.V:

                                bottle.Empty();
                                Console.WriteLine("\nLa bouteille est vide, elle contient maintenant {0}L\n", bottle.GetCurrentVolume());

                                break;

                            case ConsoleKey.Add:


                                bottle.Fill(SaisieDouble("De combien de L voulez vous remplir la bouteille ?"));
                                Console.WriteLine("\nLa bouteille contient maintenant " + bottle.GetCurrentVolume() + "L\n");

                                break;

                            case ConsoleKey.Subtract:

                                number = SaisieDouble("De combien de L voulez vous vider la bouteille ?");
                                bottle.Empty(number);
                                Console.WriteLine("\nLa bouteille contient maintenant " + bottle.GetCurrentVolume() + "L\n");
                                break;

                            case ConsoleKey.Q:

                                break;
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Erreur" + e.Message);
                        //Console.WriteLine("Erreur" + e.StackTrace);
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

