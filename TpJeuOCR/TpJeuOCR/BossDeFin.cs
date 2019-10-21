using System;
using System.Collections.Generic;
using System.Text;

namespace TpJeuOCR
{
    class BossDeFin
    {
        private int ptsDeVies;
        private bool estVivant;

        public BossDeFin(int _points)
        {
            PtsDeVies = _points;
        }

        public void Attaque(Joueur _personnage)
        {
            int nbPoints = LancerDeDes(26);
            _personnage.SubitDegats(nbPoints);
        }

        public int LancerDeDes(int _valeur)
        {
            return De.LanceLeDe(_valeur);
        }

        public void SubitDegats(int _valeur)
        {
            PtsDeVies -= _valeur;
        }

        public int PtsDeVies
        {
            get
            {
                return ptsDeVies;
            }

            private set
            {
                ptsDeVies = value;
            }
        }

        public bool EstVivant
        {
            get
            {
                return PtsDeVies > 0;
            }
        }
    }
}
