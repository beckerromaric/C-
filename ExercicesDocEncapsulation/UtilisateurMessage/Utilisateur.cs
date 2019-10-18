using System;
using System.Collections.Generic;
using System.Text;

namespace UtilisateurMessage
{
    class Utilisateur
    {
        private string prenom;
        private string nom;
        private string statut;

        public Utilisateur(string _prenom, string _nom, string _statut)
        {
            this.prenom = _prenom;
            this.nom = _nom;
            this.statut = _statut;
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

        internal string Statut
        {
            get
            {
                return statut;
            }

            set
            {
                statut = value;
            }
        }

        public override string ToString()
        {
            return "Utilisateur: " + this.prenom + " " + this.nom + ", " + this.statut;
        }
    }
}
