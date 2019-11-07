using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDu421
{
    public class Partie
    {
        private int nbManche;
        private int nbPoints;
        private int compteurPoint;
        Lancer monLancerCourant = new Lancer();


        public int NbMaxLancers { get; } = 3;

        public Partie(int _nbManche)
        {
            NbPoints = _nbManche * 10;
            //NbMaxLancers = _nbManche * 3;
            nbManche = _nbManche;
        }

        public void NouveauLancer()
        {
            monLancerCourant = new Lancer();
            nbManche--;
        }

        public void MajPoints()
        {
            if(monLancerCourant.EstGagnant())
            {
                this.nbPoints = NbPoints + 30;
            }
            else
            {
                this.nbPoints = NbPoints - 15;
            }
        }

        public bool EstPerdue()
        {
            if(NbPoints <= 0 )
            {
                return false;
            }
            return true;
        }



        public int NumLancer
        {
            get
            {
                return nbManche;
            }

            set
            {
                nbManche = value;
            }
        }

        public int NbPoints
        {
            get
            {
                return nbPoints;
            }

            set
            {
                nbPoints = value;
            }
        }
    }
}
