using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point proie = new Point(20, 20);
        laPieceSerpent laTete = new laPieceSerpent()
        { coordonnees = new Point(10, 10) };
        int nx = 1, ny = 0, score = 1;


        private void leTemps_Tick(object sender, EventArgs e)
        {
            laPieceSerpent.leGraphique.Clear(Color.White);
            this.Text = score.ToString();
            laPieceSerpent.leGraphique.FillRectangle(
                new SolidBrush(Color.Red),
                proie.X * laPieceSerpent.tailleX,
                proie.Y * laPieceSerpent.tailleY,
                laPieceSerpent.tailleX,
                laPieceSerpent.tailleY);
            laTete = new laPieceSerpent()
            {
                coordonnees =
new Point((laTete.coordonnees.X + nx +
laPieceSerpent.tailleDuJeu) % laPieceSerpent.tailleDuJeu,
(laTete.coordonnees.Y + ny +
laPieceSerpent.tailleDuJeu) % laPieceSerpent.tailleDuJeu),
                PiecePrecedente = laTete
            };
            if (laTete.coordonnees.Equals(proie))
            {
                score++;
                proie = new Point(new System.Random().Next(laPieceSerpent.tailleDuJeu),
new System.Random().Next(laPieceSerpent.tailleDuJeu));
            }
            laTete.diminution(score);
            laTete.PiecePrecedente.BitItSelf(laTete.coordonnees);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    nx = nx + (nx - 1) * (nx + 1); ny = 0;
                    break;
                case Keys.Right:
                    nx = nx - (nx - 1) * (nx + 1); ny = 0;
                    break;
                case Keys.Up:
                    nx = 0; ny = ny + (ny - 1) * (ny + 1);
                    break;
                case Keys.Down:
                    nx = 0; ny = ny - (ny - 1) * (ny + 1);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            laPieceSerpent.leGraphique = lblTerrain.CreateGraphics();
            laPieceSerpent.tailleX = this.Width / laPieceSerpent.tailleDuJeu;
            laPieceSerpent.tailleY = this.Height / laPieceSerpent.tailleDuJeu;
            leTemps.Enabled = true;
        }



    }
}


