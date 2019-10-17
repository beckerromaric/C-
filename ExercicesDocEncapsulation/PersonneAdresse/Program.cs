using System;

namespace PersonneAdresse
{
    class Program
    {
        static void Main(string[] args)
        {
            Adresse paris = new Adresse(2, "rue Victor Hugo", 75008, "Paris");
            Adresse nantes = new Adresse(17, "rue de la républicque", 44000, "Nantes");
            Adresse lille = new Adresse(55, "Bld de la Libération", 5900, "Lille");

            Console.WriteLine(paris.ToString());
            Console.WriteLine(nantes.ToString());
            Console.WriteLine(lille.ToString());
        }
    }
}
