using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class laPieceSerpent
    {
        public Point coordonnees;
        public static Graphics leGraphique;
        public laPieceSerpent PiecePrecedente;
        public static int tailleX, tailleY, tailleDuJeu = 40;
        public void diminution(int length)
        {
            if (length-- <= 0) { PiecePrecedente = null; return; }
            PiecePrecedente.diminution(length);
            leGraphique.FillRectangle(new SolidBrush(Color.Blue),
coordonnees.X * tailleX, coordonnees.Y * tailleY, tailleX, tailleY);
        }
        public void BitItSelf(Point laTete)
        {
            if (coordonnees.Equals(laTete))
            { Application.Exit(); }
            else if (PiecePrecedente != null)
            { PiecePrecedente.BitItSelf(laTete); }

        }
    }
}