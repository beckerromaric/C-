using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDu421
{
    public class Lancer
    {

         De [] mesDes = new De[3]; 

        public Lancer()
        {
            for (int i = 0; i < mesDes.Length; i++)
            {
                mesDes[i] = new De();
                mesDes[i].Jeter();
            }
            Trier();
        }

        public void LancerUnDe(int _numDe)
        {
            mesDes[_numDe - 1].Jeter();
            Trier();
        }

        private void Trier()
        {
            bool estTrie;

            do
            {
                estTrie = false;

                for (int i = 0; i < mesDes.Length - 1; i++)
                {
                    if(mesDes[i].ValeurDe < mesDes[i + 1].ValeurDe)
                    {
                        estTrie = true;
                        De temp = mesDes[i];
                        mesDes[i] = mesDes[i + 1];
                        mesDes[i + 1] = temp;
                    } 
                }
            } while (estTrie == true);
        }

        public bool EstGagnant()
        {
            if(mesDes[0].ValeurDe == 4 && mesDes[1].ValeurDe == 2 && mesDes[2].ValeurDe == 1)
            {
                return true;
            }

            return false;
        }


        public int GetValeurDe(int _numDe)
        { 
            return mesDes[_numDe - 1].ValeurDe;
        }

    }
}
