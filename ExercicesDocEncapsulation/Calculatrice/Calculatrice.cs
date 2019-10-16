using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatrice
{
    class Calculatrice
    {
        

        public static void Calculer(char _operateur, double var1, double var2)
        {
            double calcul = 0;

            switch (calcul)
            {
                case '+':
                    calcul = var1 + var2;
                    Console.WriteLine(calcul);
                    break;
                case '-':
                    calcul = var1 - var2;
                    Console.WriteLine(calcul);
                    break;
                case '*':
                    calcul = var1 * var2;
                    Console.WriteLine(calcul);
                    break;
                case '/':
                    calcul = var1 / var2;
                    Console.WriteLine(calcul);
                    break;
            }
        }
    }
}
