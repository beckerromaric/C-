using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursMickaelBouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            //débugger F11 pour étape suivante
            Console.WriteLine("Programme bouteille");

            Bottle bouteille = new Bottle(2);

            //Console.WriteLine("Etat bouteille" + bouteille.Open());
            Console.WriteLine("Etat bouteille" + bouteille.Close());

            Console.WriteLine("Remplissage bouteille son volume est : ");
            Console.WriteLine(bouteille.fill(0.5d));

            Console.WriteLine("Vidage bouteille son volume est : ");
            Console.WriteLine(bouteille.empty(-5));




            Console.ReadLine();
        }
    }
}
