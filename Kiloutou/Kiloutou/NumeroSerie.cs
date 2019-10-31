using System;
using System.Collections.Generic;
using System.Text;

namespace Kiloutou
{
    public class NumeroSerie : IComparer<Voiture>
    {
        int IComparer<Voiture>.Compare(Voiture x, Voiture y)
        {
            Voiture v1 = x;
            Voiture v2 = y;

            return x.NumeroSerie.CompareTo(y.NumeroSerie);
        }

        //int IComparer<Voiture>.Compare(Voiture x, Voiture y)
        //{
        //    Voiture v = x;
        //    Voiture v1 = y;

        //    if(v.NumeroSerie > v1.NumeroSerie)
        //    {
        //        return 1;
        //    }
        //    if(v.NumeroSerie < v1.NumeroSerie)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
