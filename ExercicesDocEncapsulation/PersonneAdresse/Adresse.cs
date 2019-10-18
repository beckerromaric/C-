using System;
using System.Collections.Generic;
using System.Text;

namespace PersonneAdresse
{
    class Adresse
    {
        private int numero_rue;
        private string nom_rue;
        private int codePostal;
        private string ville;

        public Adresse(int _numeroRue, string _nomRue, int _codePostal, string _nomVille)
        {
            this.numero_rue = _numeroRue;
            this.nom_rue = _nomRue;
            this.codePostal = _codePostal;
            this.ville = _nomVille;
        }

        public int GetNumeroRue()
        {
            return numero_rue;
        }

        public void SetNumeroRue(int _numeroRue)
        {
            this.numero_rue = _numeroRue;
        }

        public string GetNomRue()
        {
            return nom_rue;
        }

        public void SetNomRue(string _nomRue)
        {
            this.nom_rue = _nomRue;
        }

        public int GetCodePostal()
        {
            return codePostal;
        }

        public void SetCodePostal(int _codePostal)
        {
            this.codePostal = _codePostal;
        }

        public string GetVille()
        {
            return ville;
        }

        public void SetVille(string _nomVille)
        {
            this.ville = _nomVille;
        }

        public override string ToString()
        {
            return GetNumeroRue() + " " + GetNomRue() + ", " + GetCodePostal() + " " + GetVille() ;
        }
    }
}
