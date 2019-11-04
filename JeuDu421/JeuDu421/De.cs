using System;

namespace JeuDu421
{
    public class De
    {
        private int valeurDe;
        private Alea alea = Alea.Instance();

        public De()
        {
            valeurDe = 0;
        }

        public void Jeter()
        {
            valeurDe = alea.Nouveau(1, 6);
        }         
        
        public int ValeurDe
        {
            get
            {
                return valeurDe;
            }
        }
    }
}
