using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiloutou
{
    public class Voiture : IComparable 
    {
        private int numeroSerie;
        private string marque;
        private string modele;
        private DateTime miseCirculation;
      
        public Voiture()
        {
            NumeroSerie = 0;
            Marque = "tech";
            Modele = "tech";
            MiseCirculation = new DateTime(2006, 04, 28);
        }

        public Voiture(int _numeroSerie, string _marque, string _modele, DateTime _miseCirculation)
        {
            NumeroSerie = _numeroSerie;
            Marque = _marque;
            Modele = _modele;
            MiseCirculation = _miseCirculation;
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

        public DateTime MiseCirculation
        {
            get
            {
                return miseCirculation;
            }

            set
            {
                miseCirculation = value;
            }
        }

        public int CompareTo(object obj)
        {
            Voiture maVoiture = (Voiture)obj;

            return this.Marque.CompareTo(maVoiture.Marque);          
        }

        public static bool IsNumeric(string _verif) => _verif.All(Char.IsDigit);

        public override string ToString()
        {
            StringBuilder tostring = new StringBuilder();
            tostring.Append("Numéro de série: " + NumeroSerie + "\n")
                    .Append("Marque: " + Marque + "\n")
                    .Append("Modèle: " + Modele + "\n")
                    .Append("Date de mise en circulation: " + MiseCirculation.ToString("dd/MM/yyyy") + "\n");

            return tostring.ToString();
        }
    }
}
