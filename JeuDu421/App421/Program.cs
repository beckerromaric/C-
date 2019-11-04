using System;
using JeuDu421;

namespace App421
{
    class Program
    {
        static void Main(string[] args)
        {
            Alea monAlea = Alea.Instance();

            monAlea.Nouveau(1, 7);

            De d = new De();
            Ecran.AfficherDe(d);
            d.Jeter();
            Ecran.AfficherDe(d);
           
        }
    }
}
