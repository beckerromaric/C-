using System;
using System.Collections.Generic;
using System.Text;

namespace TpJeuOCR
{
    class De
    {
        private static Random random;

        public De()
        {
            random = new Random();
        }

        public static int LanceLeDe()
        {
            return random.Next(1, 7);
        }

        public static int LanceLeDe(int _valeurDe)
        {
            return random.Next(1, _valeurDe);
        }
    }
}
