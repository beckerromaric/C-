using System;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {   
            Calculatrice.Calculer('+', 1, 2);
            Calculatrice.Calculer('-', 2074, 245);
            Calculatrice.Calculer('/', 42, 4);
            Calculatrice.Calculer('*', 42, 4);

            Console.ReadLine();
            
        }
    }
}
