using System;
using System.Collections.Generic;
using System.Text;

namespace Banquier
{
    public class Banque
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

            Compte compte1 = new Compte(12323, "Joto", 1000, -500);
            this.AjouterCompte(compte1);
            AjouterCompte(new Compte(12323, "Titi", 2000, -1000));
            AjouterCompte(new Compte(12323, "Dupond", 1500, -1500));
            AjouterCompte(new Compte(12323, "Durand", 1200, -500));
            AjouterCompte(new Compte(12323, "Dubois", -200, -500));
            AjouterCompte(new Compte(12323, "Duval", 750, -2000));
        }

        private void AjouterCompte(Compte _compte)
        {
            lesComptes[nbComptes] = _compte;
        }

        public string AfficherCompte()
        {
            string str = "";

            for (int i = 0; i < nbComptes; i++)
            {
                if(lesComptes[i] != null)
                {
                    str += lesComptes[i].AfficherCompte();
                }
            }
            return str;
        }

        public void AjouterCompter(Int64 _numeroCompte, string _nom, double _solde, double _debitAutorise)
        {
            lesComptes[nbComptes++] = new Compte(_numeroCompte, _nom, _solde, _debitAutorise);
        }
    }
}
