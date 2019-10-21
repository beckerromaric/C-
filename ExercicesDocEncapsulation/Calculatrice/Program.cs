using System;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculatrice.Calculer('+', 1, 2));
            Console.WriteLine(Calculatrice.Calculer('-', 2074, 245));
            Console.WriteLine(Calculatrice.Calculer('/', 42, 4));
            Console.WriteLine(Calculatrice.Calculer('*', 42, 4));

            Console.ReadLine();
            
        }
    }
}
