using System;
using System.Collections.Generic;
using System.Text;

namespace TpComptesBancaires
{
    class Banque
    {
        private int nbComptes;
        private Compte[] lesComptes;

        public Banque()
        {
            lesComptes = new Compte[20];
            this.nbComptes = 0;
        }

        public void Init()
        {
            Compte compte1 = new Compte(12345, "Jojo", 1000, -500);
            Compte compte2 = new Compte(45785, "Jaja", 2000, -1000);
            Compte compte3 = new Compte(21574, "Jiji", 2000, -1500);
            Compte compte4 = new Compte(45745, "Juju", 1200, -500);
            Compte compte5 = new Compte(48715, "Jyjy", -200, -500);

            this.AjouteCompte(compte1);
            this.AjouteCompte(compte2);
            this.AjouteCompte(compte3);
            this.AjouteCompte(compte4);
            this.AjouteCompte(compte5);
        }

        private void AjouteCompte(Compte _unCompte)
        {
            lesComptes[nbComptes++] = _unCompte;
        }

        public string AfficherComptes()
        {
            string str = "";

            for(int i = 0; i < lesComptes.Length; i++)
            {
                if(lesComptes[i] != null)
                {
                    str += lesComptes[i].Afficher();
                }
                //return str;
            }

            return str;
        }

        public void AjouterCompte(int _numeroCpt, string _nom, double _solde, double _decouvert)
        {
            lesComptes[nbComptes++] = new Compte(_numeroCpt, _nom, _solde, _decouvert);
        }

        public string CompteSuperieur()
        {
            string resultat = "";
            
            for (int i = 0; i < lesComptes.Length; i++)
            {
                if (lesComptes[i].Superieur(lesComptes[i+1]))
                {
                    resultat = lesComptes[i].Afficher();
                    
                }
            }

            return resultat;
        }

        public Compte CheckCompte(int _numeroCompte)
        {
            for (int i = 0; i < lesComptes.Length; i++)
            {
                if (lesComptes[i].Numero == _numeroCompte)
                {
                    return lesComptes[_numeroCompte];
                }
            }

            return null;
        }
    }
}
