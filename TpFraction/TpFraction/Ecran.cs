using System;
using System.Collections.Generic;
using System.Text;

namespace TpFraction
{
    class Ecran
    {
        public static string Affiche(Fraction _fraction)
        {
            if (_fraction.Denominateur.Equals(0))
            {
                return _fraction.Numerateur.ToString();
            }

            return _fraction.Numerateur.ToString() + " / " + _fraction.Denominateur.ToString();
        }

    }
}
