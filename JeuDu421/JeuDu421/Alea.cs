using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDu421
{
    public class Alea : Random
    {
        private static Alea monAlea = null;
        public Alea()
        {

        }

        public static Alea Instance()
        {
            if (monAlea == null)
            {
                monAlea = new Alea();
            }

            return monAlea;
        }

        public int Nouveau(int _valMin, int _valMax)
        {
            return base.Next(_valMin, _valMax + 1);
        }

        public int Nouveau(int _valMax)
        {
            return base.Next(_valMax + 1);
        }

        public double NouveauReel()
        {
            return base.NextDouble();
        }
    }
}
