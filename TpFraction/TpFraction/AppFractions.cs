using System;

namespace TpFraction
{
    class AppFractions
    {
        static void Main(string[] args)
        {
            ////INVERSE OPPOSE
            //Fraction f1 = new Fraction(12, 7);
            //Fraction f2 = new Fraction();
            //Fraction f3 = new Fraction(9);

            //Console.WriteLine(Ecran.Affiche(f1));
            //Console.WriteLine(Ecran.Affiche(f2));
            //Console.WriteLine(Ecran.Affiche(f3));

            //Fraction f = new Fraction(4, 7);

            //f.Oppose();

            //Console.WriteLine(Ecran.Affiche(f));

            //f.Inverse();

            //Console.WriteLine(Ecran.Affiche(f));

            //SUPERIEUR
            //-------------------------------------------------------------------------------------
            //Fraction f = new Fraction(11, 7);
            //Fraction f1 = new Fraction(5, 4);

            //f.Superieur(f1);

            //if (f.Superieur(f1))
            //{
            //    Console.WriteLine("Vrai");
            //}
            //else
            //{
            //    Console.WriteLine("Faux");
            //}

            //INFERIEUR
            //----------------------------------------------------------------------
            //Fraction f = new Fraction(11, 7);
            //Fraction f1 = new Fraction(5, 4);

            //f.Inferieur(f1);

            //if (f.Inferieur(f1))
            //{
            //    Console.WriteLine("Vrai");
            //}
            //else
            //{
            //    Console.WriteLine("Faux");
            //}

            //EGALITE
            //------------------------------------------------------------------------

            //Fraction f = new Fraction(11, 7);
            //Fraction f1 = new Fraction(22, 14);

            //f.Egal(f1);

            //if (f.Egal(f1))
            //{
            //    Console.WriteLine("Vrai");
            //}
            //else
            //{
            //    Console.WriteLine("Faux");
            //}

            //PGCD
            //------------------------------------------------------------------------------
            //Fraction f = new Fraction(-75, 90);

            //Console.WriteLine(f.GetPgcd().ToString());
            //----------------------------------------------
            //Fraction f = new Fraction(120, -150);
            //f.Reduire();
            //Console.WriteLine(Ecran.Affiche(f));


            //Soustraction et additions
            //--------------------------------------------------

            //Fraction f = new Fraction(2, 9);
            //Fraction f1 = new Fraction(3, 4);

            //Console.WriteLine(Ecran.Affiche(f.Somme(f1)));
            //Console.WriteLine(Ecran.Affiche(f.Difference(f1)));

            //Multiplication
            //------------------------------------------------------------------------

            //Fraction f = new Fraction(5, 3);
            //Fraction f1 = new Fraction(7, 6);
            //Console.WriteLine(Ecran.Affiche(f.Produit(f1)));

            //Division
            //---------------------------------------------------------------
            //Fraction f = new Fraction(1, 2);
            //Fraction f1 = new Fraction(3, 4);
            //Console.WriteLine(Ecran.Affiche(f.Quotient(f1)));


            //Puissance
            //-----------------------------------------------------------------------

            Fraction f = new Fraction(12, 16);

            Console.WriteLine(Ecran.Affiche(f.Puissance(2)));
        }

    }
}
