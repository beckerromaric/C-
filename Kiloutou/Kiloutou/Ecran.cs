using System;
using System.Collections.Generic;
using System.Text;

namespace Kiloutou
{
    public class Ecran
    {
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

        public static void AfficherModeleNum(int _numModele, List<Voiture> _flotte)
        {
            Voiture v = new Voiture();


            List<Voiture> resultat = _flotte.FindAll(voit => voit.Modele.Contains(_numModele.ToString()));

            Console.WriteLine("-----------Début de l'extraction\n");

            foreach (var uneVoiture in resultat)
            {
                Console.WriteLine(uneVoiture);
            }

            Console.WriteLine("\n--------Fin de l'extraction");
        }         

      
    }
}
