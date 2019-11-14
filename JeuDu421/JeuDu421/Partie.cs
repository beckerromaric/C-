using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDu421
{
    public class Partie
    {
        private int nbMaxLancers;
        private int nbManche;
        private int nbPoints;
        Lancer monLancerCourant = new Lancer();

        public Partie(int _nbManche)
        {
            NbPoints = _nbManche * 10;
            NbManche = _nbManche;
            NbMaxLancers = _nbManche * 3;
        }

 

        public void NouveauLancer()
        {
            monLancerCourant = new Lancer();
            NbrLancer = 3;
            NbManche--;
            //monLancerCourant.LancerUnDe(3);
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

        public void Lancer1(int _de1)
        {
            MonLancerCourant.LancerUnDe(_de1);
            MonLancerCourant.Trier();
            NbrLancer--;
            if (MonLancerCourant.EstGagnant())
            {
                MajPoints();
            }

        }

        public void Lancer2(int _de1, int _de2)
        {
            MonLancerCourant.LancerUnDe(_de1);
            MonLancerCourant.LancerUnDe(_de2);
            MonLancerCourant.Trier();
            NbManche--;
            if (MonLancerCourant.EstGagnant())
            {
                MajPoints();
            }
        }

        public void Lancer3()
        {
            MonLancerCourant.LancerUnDe(3);
            MonLancerCourant.Trier();
            NbrLancer--;
            if (MonLancerCourant.EstGagnant())
            {
                MajPoints();
            }
        }

        public bool EstPerdue()
        {
            if (NbPoints <= 0)
            {
                return false;
            }
            return true;
        }

        public int NbManche { get; set; }
        public int NbrLancer { get; set; }
        public int NbMaxLancers { get; }

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

        public Lancer MonLancerCourant
        {
            get
            {
                return monLancerCourant;
            }

            set
            {
                monLancerCourant = value;
            }
        }
    }
}
