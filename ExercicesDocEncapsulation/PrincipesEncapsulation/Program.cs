using System;

namespace PrincipesEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Passage dans le main");

            Personne martin = new Personne("martin", "Java SARL");
            Personne dupont = new Personne("dupont");

            martin.Afficher();
            dupont.Afficher();

            Personne durand = new Personne("durand", "J2E SA");
            durand.Afficher();
            durand.QuitterSociete();
            durand.Afficher();
            durand.SetSociete("EJB Corporate");
            durand.Afficher();
        }
    }
}
