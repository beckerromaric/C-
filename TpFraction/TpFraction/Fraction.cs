using System;
using System.Collections.Generic;
using System.Text;

namespace TpFraction
{
    class Fraction
    {
        private int numerateur;
        private int denominateur;

        public Fraction()
        {
            this.numerateur = 0;
        }

        public Fraction(int _numerateur)
        {
            this.numerateur = _numerateur;

        }
        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        public void Oppose()
        {
            this.numerateur =   - Numerateur;
            this.denominateur = Denominateur;
        }

        public void Inverse()
        {
            int temp = Numerateur;
            this.numerateur = Denominateur; 
            this.denominateur = temp;
        }

        public bool Superieur(Fraction _fraction)
        {
            if ((Numerateur /(double)Denominateur) > (_fraction.Numerateur / (double)(_fraction.Denominateur)))
            {
                return true;
            }

            return false;
        }

        public bool Inferieur(Fraction _fraction)
        {
            if((Numerateur / Denominateur) < (_fraction.Numerateur / _fraction.Denominateur))
            {
                return true;
            }
            return false;
        }

        public bool Egal(Fraction _fraction)
        {
            if((Numerateur / Denominateur) == (_fraction.Numerateur / _fraction.Denominateur))
            {
                return true;
            }
            return false;
        }

        private int GetPgcd()
        {
            //int a = this.numerateur;
            //int b = this.denominateur;
            //int temp,resultat;
            //int pgcd = 1;

            //if(b > a)
            //{
            //    temp = a;
            //    a = b;
            //    b = temp;
            //}
            //do
            //{
            //    resultat = a % b;
            //    a = b;
            //    b = resultat;

            //}
            //while (resultat != 0);

            //return a;

            int x = Numerateur;
            int y = Denominateur;
            int m;

            // check if numerator is greater than the denominator, 
            // make m equal to denominator if so
            if (x > y)
                m = y;
            else
                // if not, make m equal to the numerator
                m = x;

            // assign i to equal to m, make sure if i is greater
            // than or equal to 1, then take away from it
            for (int i = m; i >= 1; i--)
            {
                if (x % i == 0 && y % i == 0)
                {
                    //return the value of i
                    return i;
                }
            }

            return 1;
        }

        public void Reduire()
        {
            int pgcd = GetPgcd();

            if(pgcd != 0)
            {
                this.numerateur = Numerateur / pgcd;
                this.denominateur = Denominateur / pgcd;
            }
            //if (Denominateur < 0)
            //{
            //    this.denominateur = Denominateur * -1;
            //    this.numerateur = Numerateur * -1;
            //}

            //if (this.numerateur < 0 && this.denominateur < 0)
            //{
            //    this.numerateur = -this.numerateur;
            //    this.denominateur = -this.denominateur;
            //}

            //this.numerateur = this.numerateur / pgcd;
            //this.denominateur = this.denominateur / pgcd;

        }

        public Fraction Somme(Fraction _fraction)
        {
            int a = this.numerateur;
            int b = _fraction.numerateur;
            int c = this.denominateur;
            int d = _fraction.denominateur;
            int pgcd = GetPgcd();
            double tempNum;
            double tempDenom;

            if (this.denominateur == _fraction.denominateur)
            {
                this.numerateur = this.numerateur + _fraction.numerateur;
                return _fraction;
            }

            else if (this.denominateur != _fraction.denominateur)
            {
                _fraction.numerateur = (a * d) + (b * c);
                _fraction.denominateur = c * d;

                tempNum = _fraction.numerateur / pgcd;
                tempNum = _fraction.numerateur / pgcd;

                return _fraction;
            }
            return null;
        }
        public int Numerateur
        {
            get
            {
                return numerateur;
            }
        }

        public int Denominateur
        {
            get
            {
                return denominateur;
            }
        }

    }
}
