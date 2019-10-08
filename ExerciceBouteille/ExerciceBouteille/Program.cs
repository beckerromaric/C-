using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceBouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            Bottle bottle = new Bottle(1.5d);

            Console.WriteLine("La capacité de la bouteille est " + bottle.GetCapacity());

            bool close = bottle.Close();
            double pleine = bottle.Fill();



            //bool open = bottle.Open();
            //double fill = bottle.Fill();

            //bool o = bottle.Open();
            //Console.WriteLine(o);

            //bool f = bottle.Close();
            //Console.WriteLine(f);

            //double r = bottle.Fill();
            //Console.WriteLine(r);

            //double vp = bottle.Empty(0.5d);
            //Console.WriteLine(vp);

            //double rp = bottle.Fill(0.5d);
            //Console.WriteLine(rp);

            //double v = bottle.Empty();
            //Console.WriteLine(v);

            //----------------------------------------------------------------
            //Exemple ternaire

            bool isOpen = true;

            string str = (isOpen ? "ouverte" : "fermée");
            Console.WriteLine("La bouteille est {0}", str);


            // meme version qu'au dessus mais en raccourcis 
            Console.WriteLine("La bouteille est {0}", isOpen ? "ouverte" : "fermée");


            Console.ReadLine();
        }
    }
}
