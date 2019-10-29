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
            Voiture v = new Voiture();
            Voiture v1 = new Voiture(12341, "Pigeot", "LePaysDuVelo");

            //Console.WriteLine(v);
            //Console.WriteLine(v1);

            List<Voiture> listVoiture = new List<Voiture>();

            listVoiture.Add(new Voiture(2098, "Peugeot", "307"));
            listVoiture.Add(new Voiture(1987, "Renault", "Espace"));
            listVoiture.Add(new Voiture(1203, "Lancia", "Dedra"));
            listVoiture.Add(new Voiture(3049, "Bmw", "324d"));
            listVoiture.Add(new Voiture(1500, "Peugeot", "406"));
            listVoiture.Add(new Voiture(2500, "Ford", "Mondeo"));

            //Console.WriteLine(listVoiture[2]);

            //Pour le tri défini dans la classe Voiture
            listVoiture.Sort();

            //Pour le tri défini dans la classe Modele
            Modele parModele = new Modele();

            listVoiture.Sort(parModele);

            

            foreach (Voiture voiture in listVoiture)
            {
                Console.WriteLine(voiture);
            }

        }
    }
}
