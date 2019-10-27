using System;
using Banquier;

namespace AppBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque bnp = new Banque();
            bnp.Init();

            bnp.LesComptes.Add(new Compte(12456, "Haddock", 1500, -600));
            Compte toto = new Compte();
            Ecran.AfficherBanque(bnp);
        }
    }
}
