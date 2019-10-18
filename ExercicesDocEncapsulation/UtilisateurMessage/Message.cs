using System;
using System.Collections.Generic;
using System.Text;

namespace UtilisateurMessage
{
    class Message
    {
        private string titre;
        private string texte;
        private DateTime dateCreation;
        private Utilisateur utilisateur;
        private Forum ajouterUtilisateurMessages;

        public Message(string _titre, string _texte, Utilisateur _utilisateur)
        {
            this.Titre = _titre;
            this.Texte = _texte;
            this.utilisateur = _utilisateur;
            this.dateCreation = DateTime.Now;


        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Texte
        {
            get
            {
                return texte;
            }

            set
            {
                texte = value;
            }
        }

        public DateTime DateCreation
        {
            get
            {
                return dateCreation;
            }
        }

        internal Utilisateur Utilisateur
        {
            get
            {
                return utilisateur;
            }
        }

        public override string ToString()
        {
            return titre + "--" + texte + "\nDate de création: " + DateCreation + "\n" + utilisateur;
        }

        public string GetAuteur()
        {
            return utilisateur.Prenom + " " + utilisateur.Nom + ", " + utilisateur.Statut;
        }
    }
}
