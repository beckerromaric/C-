using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipesEncapsulation
{
    class Personne
    {
        private string nom;

        private string societe;

        private const string PAS_DE_SOCIETE = "?";
        public Personne(string _nom)
        {
            this.nom = _nom.ToUpper();
            this.societe = PAS_DE_SOCIETE;
        }

        public Personne(string _nom, string _societe)
        {
            this.nom = _nom.ToUpper();
            this.societe = _societe;
        }

        public void Afficher()
        {
            if(this.societe == PAS_DE_SOCIETE)
            {
                Console.WriteLine("\nJe m'appelle {0} et je ne suis pas employé d'une société.", GetNom());
            }
            else
            {
                Console.WriteLine("\nJe m'apelle {0} et je travaille chez {1}", GetNom(), GetSociete());
            }
        }

        private void ValiderSociete(string _societe)
        {
            if (_societe.Length <= 30 && _societe != PAS_DE_SOCIETE)
            {
                this.societe = PAS_DE_SOCIETE;
            }
            else
            {
                Console.WriteLine("Vous essayez de quitter une societe sans en faire parti!!");
            }
        }

        public void QuitterSociete()
        {
            if(societe == PAS_DE_SOCIETE)
            {
                Afficher();
                Console.WriteLine("Erreur vous devez quitter");
            }

            this.societe = PAS_DE_SOCIETE;
        }
        public string GetNom()
        {
            return this.nom;
        }

        public void SetNom(string _nom)
        {
            this.nom = _nom;
        }
        public string GetSociete()
        {
            return this.societe;
        }

        public void SetSociete(string _societe)
        {
            this.societe = _societe;
        }
    }
}
