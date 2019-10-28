using System;
using Kiloutou;

namespace AppKiloutou
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture();
            Voiture v1 = new Voiture(12341, "Pigeot", "LePaysDuVelo");

            Console.WriteLine(v1);
        }
    }
}
