using System;
using Kiloutou;
using System.Collections.Generic;
using System.Collections;

namespace AppKiloutou
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test des constructeurs
            Voiture v = new Voiture();
            Voiture v1 = new Voiture(12341, "Pigeot", "LePaysDuVelo", new DateTime(1854, 05, 05));

            //Console.WriteLine(v);
            //Console.WriteLine(v1);

            //Création de la collection typée
            List<Voiture> listVoiture = new List<Voiture>();

            listVoiture.Add(new Voiture(2098, "Peugeot", "307",new DateTime(1998, 08, 24)));
            listVoiture.Add(new Voiture(1987, "Renault", "Espace", new DateTime(2001, 09, 28)));
            listVoiture.Add(new Voiture(1203, "Lancia", "Dedra", new DateTime(1996, 10, 05)));
            listVoiture.Add(new Voiture(3049, "Bmw", "324d", new DateTime(2001, 04, 15)));
            listVoiture.Add(new Voiture(1500, "Peugeot", "406", new DateTime(1995, 12, 24)));
            listVoiture.Add(new Voiture(2500, "Ford", "Mondeo", new DateTime(2007, 05, 30)));

            //Console.WriteLine(listVoiture[2]);

            //Pour le tri défini dans la classe Voiture
            listVoiture.Sort();

            //Pour le tri défini dans la classe Modele
            Modele parModele = new Modele();
            listVoiture.Sort(parModele);

            //pour le tri défini dans la classe NumeroSerie
            NumeroSerie parNumero = new NumeroSerie();
            listVoiture.Sort(parNumero);

            //Pour le tri défini dans la classe ParDate

            ParDate parDate = new ParDate();

            listVoiture.Sort(parDate);

            //Affichage de la collection
            foreach (Voiture voiture in listVoiture)
            {
                Console.WriteLine(voiture);
            }

        }
    }
}
