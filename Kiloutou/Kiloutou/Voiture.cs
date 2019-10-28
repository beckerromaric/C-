using System;
using System.Collections.Generic;

namespace Kiloutou
{
    public class Voiture
    {
        private int numeroSerie;
        private string marque;
        private string modele;
        private List<Voiture> listVoiture;
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

        public void Init()
        {
            listVoiture.Add(new Voiture(2098, "Peugeot", "307"));
            listVoiture.Add(new Voiture(1987, "Renault", "Espace"));
            listVoiture.Add(new Voiture(1203, "Lancia", "Dedra"));
            listVoiture.Add(new Voiture(3049, "Bmw", "324d"));
            listVoiture.Add(new Voiture(1500, "Peugeot", "406"));
            listVoiture.Add(new Voiture(2500, "Ford", "Mondeo"));
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

        public override string ToString()
        {
            return ($"Numéro de série: {this.NumeroSerie}\nMarque: {this.Marque}\nModèle:{this.Modele}\n");
        }
    }
}
