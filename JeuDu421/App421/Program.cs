using System;
using JeuDu421;

namespace App421
{
    class Program
    {
        static void Main(string[] args)
        {
            Alea monAlea = Alea.Instance();
            Lancer monl = new Lancer();
            monAlea.Nouveau(1, 7);

            monl.LancerUnDe(3);

            Console.WriteLine(monl);
            //De d = new De();
            //Ecran.AfficherDe(d);
            //d.Jeter();
            //Ecran.AfficherDe(d);



        }
    }
}
