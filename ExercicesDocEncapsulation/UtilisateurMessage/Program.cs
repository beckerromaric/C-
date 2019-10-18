using System;

namespace UtilisateurMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Utilisateur jean = new Utilisateur("Jean", "Dupont", "STANDARD");
            Utilisateur bernard = new Utilisateur("Bernard", "Morin", "STANDARD");
            Utilisateur nathalie = new Utilisateur("Nathalie", "Morin", "MODERATEUR");

            Console.WriteLine(jean.ToString());
            Console.WriteLine(bernard.ToString());
            Console.WriteLine(nathalie.ToString());

            Message message1 = new Message("Java SE", "L'encapsulation est une propriété fondamentale", jean);

            Console.WriteLine(message1.ToString());


            Console.ReadLine();
        }
    }
}
