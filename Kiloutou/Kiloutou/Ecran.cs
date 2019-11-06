using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiloutou
{
    public class Ecran
    {
        //Méthode pour afficher toute les voiture d'une marque choisie en paramètre.
        public static void AfficherListe(List<Voiture> _flotte, string _marque)
        {
            List<Voiture> resultat = _flotte.FindAll(voit => voit.Marque == _marque);
            
            Console.WriteLine("-----------Début de l'extraction\n");

            foreach (var uneVoiture in resultat)
            {
                Console.WriteLine(uneVoiture);
            }

            Console.WriteLine("\n--------Fin de l'extraction");
        }

        //Méthode pour afficher tout les numéros de séries compris dans une tranche
        public static void AfficherNumero(int _borneMin, int _borneMax, List<Voiture> _flotte)
        {
            List<Voiture> resultat = _flotte.FindAll(voit => voit.NumeroSerie < _borneMax && voit.NumeroSerie > _borneMin);
            
            Console.WriteLine("-----------Début de l'extraction\n");

            foreach (var uneVoiture in resultat)
            {
                Console.WriteLine(uneVoiture);
            }

            Console.WriteLine("\n--------Fin de l'extraction");
        }

        //Methode pour rechercher des modèles qui contiennent des numéros
        public static void RechercheModeleNum(int _numModele, List<Voiture> _flotte)
        {

            List<Voiture> resultat = _flotte.FindAll(voit => voit.Modele.Contains(_numModele.ToString()));

            Console.WriteLine("-----------Début de l'extraction\n");

            foreach (var uneVoiture in resultat)
            {
                Console.WriteLine(uneVoiture);
            }

            Console.WriteLine("\n--------Fin de l'extraction");
        }


        //Methode pour afficher tout les modèles qui sont un numéro ( 3 methodes différentes ) 
        //public static void AfficherModeleNum( List<Voiture> _flotte)
        //{

        //    List<Voiture> resultat = new List<Voiture>();

        //    for (int i = 0; i < _flotte.Count; i++)
        //    {
        //        int modele = 0;
        //        bool test = int.TryParse(_flotte[i].Modele, out modele);

        //        if (test)
        //        {
        //            resultat.Add(_flotte[i]);
        //        }
        //    }

        //    Console.WriteLine("-----------Début de l'extraction\n");

        //    foreach (var uneVoiture in resultat)
        //    {
        //        Console.WriteLine(uneVoiture);
        //    }

        //    Console.WriteLine("\n--------Fin de l'extraction");
        //}



        //public static void AfficherModeleNum(List<Voiture> _flotte)
        //{

        //    List<Voiture> resultat = new List<Voiture>();

        //    for (int i = 0; i < _flotte.Count; i++)
        //    {
        //        if (IsNumeric(_flotte[i].Modele))
        //        {
        //            resultat.Add(_flotte[i]);
        //        }
        //    }

        //    Console.WriteLine("-----------Début de l'extraction\n");

        //    foreach (var uneVoiture in resultat)
        //    {
        //        Console.WriteLine(uneVoiture);
        //    }

        //    Console.WriteLine("\n--------Fin de l'extraction");
        //}
        public static bool IsNumeric(string _verif) => _verif.All(Char.IsDigit);
        
        public static void AfficherModeleNum(List<Voiture> _flotte)
        {
            List<Voiture> resultat = _flotte.FindAll(voit => IsNumeric(voit.Modele));

            Console.WriteLine("-----------Début de l'extraction\n");

            foreach (var uneVoiture in resultat)
            {
                Console.WriteLine(uneVoiture);
            }

            Console.WriteLine("\n--------Fin de l'extraction");
        }

    }
}
