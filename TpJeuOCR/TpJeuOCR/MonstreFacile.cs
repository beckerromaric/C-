using System;
using System.Collections.Generic;
using System.Text;

namespace TpJeuOCR
{
    class MonstreFacile
    {
        private const int degats = 10;
        protected De des;
        private bool estVivant;

        public MonstreFacile()
        {
            des = new De();
            estVivant = true;
        }

        public virtual void Attaquer(Joueur _joueur)
        {
            int lancerMob = LancerDe();
            int lancerJoueur = _joueur.LancerDe();
            if(lancerJoueur < lancerMob)
            {
                _joueur.SubitDegats(degats);
            }
        }

        public void SubitDdegats()
        {
            estVivant = false;
        }

        public int LancerDe()
        {
            return des.LanceLeDe();
        }

        public bool EstVivant
        {
            get
            {
                return estVivant;
            }

            private set
            {
                estVivant = value;
            }
        }
    }
}
