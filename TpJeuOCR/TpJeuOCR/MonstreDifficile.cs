using System;
using System.Collections.Generic;
using System.Text;

namespace TpJeuOCR
{
    class MonstreDifficile : MonstreFacile
    {
        private const int degatsSort = 5;

        public override void Attaquer(Joueur _joueur)
        {
            base.Attaquer(_joueur);
            _joueur.SubitDegats(SortMagique());
        }

        public int SortMagique()
        {
            int valeurDe = des.LanceLeDe();

            if(valeurDe == 6)
            {
                valeurDe = 0;
            }

            return valeurDe * degatsSort;
        }
    }
}
