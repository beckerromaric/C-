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

            Personne jean = new Personne("Jean", "Dupont", 30, lille);
            Personne bernard = new Personne("Bernard", "Morin", 45, paris);
            Personne nathalie = new Personne("Nathalie", "Durand", 35, nantes);

            Console.WriteLine(jean.ToString());
            Console.WriteLine(bernard.ToString());
            Console.WriteLine(nathalie.ToString());

            jean.Adresse = new Adresse(44, " rue des Docks, ", 33000, "Bordeaux");
            Console.WriteLine(jean.ToString());

            //pour acceder au setter
            nathalie.Adresse = paris;
            Console.WriteLine(nathalie.ToString());
        }
    }
}
