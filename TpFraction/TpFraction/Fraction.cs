using System;
using System.Collections.Generic;
using System.Text;

namespace TpFraction
{
    class Fraction /*: IComparable*/
    {
        //pour le prochain exercice
        //public int CompareTo(object obj)
        //{
        //    return Numerateur.CompareTo(obj);
        //}
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
            int pgcd = 1,
                a = this.Numerateur,
                b = this.Denominateur,
                temp = 0;

            if(a != 0 && b != 0)
            {
                if(a < 0)
                {
                    a = -a;
                }
                if(b < 0)
                {
                    b = -b;
                }

                do
                {
                    if(a < b)
                    {
                        temp = a;
                        a = b;
                        b = temp;
                    }

                    a -= b;

                } while (a != b);

                pgcd = a;
            }

            return pgcd;
        }
        private void Reduire()
        {
            int pgcd = this.GetPgcd();

            if(pgcd != 0)
            {
                 Numerateur /= pgcd;
                 Denominateur /= pgcd;
            }

            if (this.numerateur > 0 && this.denominateur < 0)
            {
                this.numerateur = -this.numerateur;
                this.denominateur = -this.denominateur;
            }
        }

        public Fraction Somme(Fraction _fraction)
        {
            if (this.denominateur == _fraction.denominateur)
            {
                _fraction.numerateur += this.numerateur;

                _fraction.Reduire();

                return _fraction; 
            }
            else
            {
                _fraction.numerateur = (Numerateur * _fraction.Denominateur) + (_fraction.Numerateur * Denominateur);
                _fraction.denominateur = Denominateur * _fraction.Denominateur;
                _fraction.Reduire();
                return _fraction;
            }
        }

        public Fraction Difference(Fraction _fraction2)
        {
            Fraction resultat;

            if (Denominateur == _fraction2.Denominateur)
            {
                 this.numerateur -=_fraction2.numerateur;
                resultat = new Fraction(Numerateur, Denominateur);
                resultat.Reduire();
                return resultat;
            }
            else
            {
                int a = (Numerateur * _fraction2.Denominateur) - (_fraction2.Numerateur * Denominateur);
                int b = Denominateur * _fraction2.Denominateur;

                resultat = new Fraction(a, b);
                resultat.Reduire();
                return resultat;
            }
            
        }

        public Fraction Produit(Fraction _fraction2)
        {
            Fraction resultat;

            int a = (Numerateur * _fraction2.Numerateur);
            int b = (Denominateur * _fraction2.Denominateur);

            resultat = new Fraction(_fraction2.numerateur, _fraction2.denominateur);

            resultat.Reduire();

            return resultat;
        }

        public Fraction Quotient(Fraction _fraction2)
        {
            if(Denominateur == 0 || _fraction2.denominateur == 0)
            {
                throw new ArgumentOutOfRangeException("Opération impossible ! Le dénominateur ne peux pas être égal à 0!");
            }

            Fraction resultat;

            int a = Numerateur * _fraction2.Denominateur;
            int b = Denominateur * _fraction2.Numerateur;

            resultat = new Fraction(a, b);

             resultat.Reduire();

            return resultat;

        }

        public Fraction Puissance(int exposant)
        {
            Fraction resultat = null;

            for (int i = 0; i < exposant; i++)
            {
                Numerateur = Numerateur * Numerateur;
                Denominateur = Denominateur * Denominateur;
            }

            resultat = new Fraction(Numerateur, Denominateur);
  
            return resultat;
        }

        public int Numerateur
        {
            get
            {
                return numerateur;
            }
            set
            {
                numerateur = value;
            }
        }

        public int Denominateur
        {
            get
            {
                return denominateur;
            }
            set
            {
                denominateur = value;
            }
        }

    }
}
