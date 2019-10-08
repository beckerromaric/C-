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
            Bottle bottle = new Bottle(10.5f);

            Console.WriteLine("La capacité de la bouteille est " + bottle.ToString());





            Console.ReadLine();
        }
    }
}
