using System;

namespace Banquier
{
    public class Compte
    {
        private Int64 numeroCompte;
        private string nom;
        private double solde;
        private double decouvertAutorise;

        public Compte()
        {
            Random numAlea = new Random();

            this.numeroCompte = numAlea.Next(10000000, 99999999);
            this.nom = "Compte technique";
            this.Solde = 0;
            this.DecouvertAutorise = 0;
        }

        public Compte(Int64 _numeroCompte, string _nom, double _solde, double _decouvertAutorise)
        {
            this.numeroCompte = _numeroCompte;
            this.nom = _nom;
            this.Solde = _solde;
            this.DecouvertAutorise = _decouvertAutorise;
        }

        public void Crediter(double _montant)
        {
            Solde = Solde + _montant;
        }

        public bool Debiter(double _montant)
        {
            if((Solde - _montant) < decouvertAutorise)
            {
                throw new ArgumentOutOfRangeException("Vous esssayez de débiter plus que le découvert ne vous le permet !!");
            }

            if(_montant < 0)
            {
                throw new ArgumentOutOfRangeException("Vous essayez de débiter un compte négatif !");
            }

            if(Solde - _montant >= decouvertAutorise)
            {
                Solde = Solde - _montant;
                return true;
            }

            return false;
        }

        public bool Transferer(Compte _compteDestinataire, double _montant)
        {
            if((Solde - _montant) >= DecouvertAutorise)
            {
                Solde = Solde - _montant;
                _compteDestinataire.Crediter(_montant);
            }

            return false;
        }

        //public bool 

        public string AfficherCompte()
        {
            return ($"Numéro compte : {this.numeroCompte.ToString("0000-0000-0000-0000")} \nNom client : {this.nom.ToString()} \nSolde : {this.solde.ToString()} \nDécouvert autorisé : {this.decouvertAutorise.ToString()}\n");
        }

        public Int64 NumeroCompte
        {
            get
            {
                return numeroCompte;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
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
    }
}
