using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDu421
{
    public class Lancer
    {
        private De de = new De();
        private int d1;
        private int d2 = 0;
        private int d3 = 0;

        public void LancerUnDe(int _numDe)
        {
            if(_numDe == 3)
            {
                de.Jeter();
                d1 = de.ValeurDe;
                
                de.Jeter();
                d2 = de.ValeurDe;

                de.Jeter();
                d3 = de.ValeurDe;
            }
        }

        public bool EstGagnant()
        {
            return false;
        }


        public string GetD1()
        {
            return d1.ToString();
        }

        public string GetD2()
        {
            return d2.ToString();
        }

        public string GetD3()
        {
            return d3.ToString();
        }

        public override string ToString()
        {
            return d1 + "\n" + d2 + "\n" + d3;
        }
    }
}
