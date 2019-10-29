using System;
using System.Collections.Generic;
using System.Text;

namespace Kiloutou
{
    public class Voiture : IComparable 
    {
        private int numeroSerie;
        private string marque;
        private string modele;
        // private List<Voiture> listVoiture;
      
        public Voiture()
        {
            NumeroSerie = 0;
            Marque = "tech";
            Modele = "tech";          
        }

        public Voiture(int _numeroSerie, string _marque, string _modele)
        {
            NumeroSerie = _numeroSerie;
            Marque = _marque;
            Modele = _modele;
          

        }

        public int NumeroSerie
        {
            get
            {
                return numeroSerie;
            }

            set
            {
                numeroSerie = value;
            }
        }

        public string Marque
        {
            get
            {
                return marque;
            }

            set
            {
                marque = value;
            }
        }

        public string Modele
        {
            get
            {
                return modele;
            }

            set
            {
                modele = value;
            }
        }

        public int CompareTo(object obj)
        {
            Voiture maVoiture = (Voiture)obj;

            return this.Marque.CompareTo(maVoiture.Marque);          
        }

        public override string ToString()
        {
            StringBuilder tostring = new StringBuilder();
            tostring.Append("Numéro de série: " + NumeroSerie + "\n")
                    .Append("Marque: " + Marque + "\n")
                    .Append("Modèle: " + Modele + "\n");

            return tostring.ToString();
        }
    }
}
