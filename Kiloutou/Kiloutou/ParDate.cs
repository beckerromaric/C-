using System;
using System.Collections.Generic;
using System.Text;

namespace Kiloutou
{
    public class ParDate : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.MiseCirculation.CompareTo(y.MiseCirculation);
        }
    }
}
