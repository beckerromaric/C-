using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Kiloutou
{
    public class Modele : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            Voiture v1 = x;
            Voiture v2 = y;

            return v1.Modele.CompareTo(v2.Modele);
        }
    }
    //public int Compare(object x, object y)
    //{
    //    Voiture maVoitureX = (Voiture)x;
    //    Voiture maVoitureY = (Voiture)y;

    //    if()
    //}
    ////public int Compare(object x, object y)
    ////{
    ////    Voiture v1 = (Voiture)x;
    ////    Voiture v2 = (Voiture)y;

    ////    return v1.Modele.CompareTo(v2.Modele);
    ////}

}
