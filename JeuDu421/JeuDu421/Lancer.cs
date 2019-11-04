using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDu421
{
    class Lancer
    {
        private int[] mesDe = new int[] {};

        public Lancer(De _de)
        {
            mesDe[0] = _de.ValeurDe;
        }

        public Lancer(De _de, De _de1)
        {
            mesDe[0] = _de.ValeurDe;
            mesDe[1] = _de1.ValeurDe;
        }
    }
}
