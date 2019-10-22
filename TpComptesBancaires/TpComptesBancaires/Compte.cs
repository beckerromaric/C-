using System;
using System.Collections.Generic;
using System.Text;

namespace TpComptesBancaires
{
    class Compte
    {
        private double decouvertAutorise;

        private string nomClient;

        private int numero;

        private double solde;

        public Compte()
        {
            Random numAlea = new Random();
            this.numero = numAlea.Next(100000000, 999999999);
            this.nomClient = "compte par defaut";
            this.Solde = 0;
            this.DecouvertAutorise = 0;
        }

        public Compte(int _numero, string _nomClient, double _solde, double _decouvert)
        {
            this.numero = _numero;
            this.nomClient = _nomClient;
            this.Solde = _solde;
            this.DecouvertAutorise = _decouvert;
        }

        public void Crediter(double _montant)
        {
            Solde = Solde + _montant;
        }

        public bool Debiter(double _montant)
        {
            if((Solde - _montant) > DecouvertAutorise)
            {
                Solde -= _montant;
                return true;
            }

            return false;
        }

        public bool Transferer(double _montant, Compte _autreCompte)
        {
            if((Solde - _montant) > DecouvertAutorise)
            {
                Solde = Solde - _montant;
                _autreCompte.Solde += _montant;
                return true;
            }

            return false;
        }

        public bool Superieur(Compte _autreCompte)
        {
            if(Solde > _autreCompte.Solde)
            {
                return true;
            }
            return false;
        }

        public double DecouvertAutorise
        {
            get
            {
                return decouvertAutorise;
            }

            set
            {
                decouvertAutorise = value;
            }
        }

        public string NomClient
        {
            get
            {
                return nomClient;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public double Solde
        {
            get
            {
                return solde;
            }

            set
            {
                solde = value;
            }
        }

        public string Afficher()
        {
            return "Numéro compte : " + Numero + " Nom client: " + NomClient + " Solde: " + Solde + " Découvert Autorisé" + DecouvertAutorise;
        }
    }
}
