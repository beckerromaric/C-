using System;
using System.Collections.Generic;
using System.Text;

namespace TpJeuOCR
{
    class De
    {
        private Random random;

        public De()
        {
            random = new Random();
        }

        public int LanceLeDe()
        {
            return random.Next(1, 7);
        }

        public int LanceLeDe(int _valeurDe)
        {
            return random.Next(1, _valeurDe);
        }
    }
}
