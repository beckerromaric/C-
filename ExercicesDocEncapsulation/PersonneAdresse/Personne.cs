using System;
using System.Collections.Generic;
using System.Text;

namespace PersonneAdresse
{
    class Personne
    {
        private string prenom;
        private string nom;
        private int age;
        private Adresse adresse;

        public Personne(string _prenom, string _nom, int _age, Adresse _adresse)
        {
            this.Prenom = _prenom;
            this.Nom = _nom;
            this.Age = _age;
            this.Adresse = _adresse;
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        internal Adresse Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        //public void SetPrenom(string _prenom)
        //{
        //    this.prenom = _prenom;
        //}

        //public string GetPrenom()
        //{
        //    return this.prenom;
        //}

        //public void SetNom(string _nom)
        //{
        //    this.nom = _nom;
        //}

        //public string GetNom()
        //{
        //    return nom;
        //}

        //public void SetAge(int _age)
        //{
        //    this.age = _age;
        //}

        //public int GetAge()
        //{
        //    return age;
        //}

        public string ToString()
        {
            return "\n" + this.Prenom + " " + this.Nom + " " + this.age + " ans, habite au " + this.adresse + "\n";
        }
    }
}
