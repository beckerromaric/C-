using System;
using System.Collections.Generic;
using System.Text;

namespace TpJeuOCR
{
    class Joueur
    {
        private De des;

        private int ptsDeVie;

        private bool estVivant;

        public Joueur(int _points)
        {
            PtsDeVie = _points;
            des = new De();
        }

        public void Attaquer(MonstreFacile _monstre)
        {
            int lancerJoueur = LancerDe();
            int lancerMonstre = LancerDe();

            if(lancerJoueur >= lancerMonstre)
            {
                _monstre.SubitDdegats();
            }
        }
        public void Attaque(BossDeFin _boss)
        {
            int nbPoints = LancerDe(26);
        }

        public bool EstVivant
        {
            get
            {
                return PtsDeVie > 0;
            }
        }

        public int PtsDeVie
        {
            get
            {
                return ptsDeVie;
            }

            private set
            {
                ptsDeVie = value;
            }
        }

        public void SubitDegats(int _degats)
        {
            if (!BouclierRenvoi())
            {
                PtsDeVie -= _degats;
            }
        }

        public bool BouclierRenvoi()
        {
            return des.LanceLeDe() <= 2;
        }

        public int LancerDe()
        {
            return des.LanceLeDe();
        }

        public int LancerDe()
        {
           
        }
    }
}
