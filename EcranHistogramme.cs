using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fil_Rouge
{
    public partial class EcranHistogramme : Form
    {
        ArrayList alData = new ArrayList();
        Random rand = new Random();

        public EcranHistogramme()
        {
            InitializeComponent();
        }

        private void bCreer_Click(object sender, EventArgs e)
        {
            alData.Clear();
            lbMonPoint.Items.Clear();
            int nombreDePoints = rand.Next(8, 16);
            int xCourant = 0;

            for (int i = 0; i < nombreDePoints; i++)
            {
                if (i > 0)
                {
                    xCourant += rand.Next(10, 25); 
                }
                int yAleatoire = rand.Next(-100, 101);

                MonPoint nouveauPoint = new MonPoint(xCourant, yAleatoire);
                alData.Add(nouveauPoint);
                lbMonPoint.Items.Add(nouveauPoint);
            }
        }

        private void bDessiner_Click(object sender, EventArgs e)
        {
            pDessin.Invalidate();
        }

        private void pDessin_Paint(object sender, PaintEventArgs e)
        {
            if (alData.Count < 2) return;

            Graphics g = e.Graphics;

            int minX = ((MonPoint)alData[0]).X;
            int maxX = ((MonPoint)alData[alData.Count - 1]).X;

            int minY = -100;
            int maxY = 100;

            int largeurDonneesX = maxX - minX;
            if (largeurDonneesX == 0) largeurDonneesX = 1;

            int hauteurDonneesY = maxY - minY; 

            Pen styloRouge = new Pen(Color.Red, 2);
            float axeY0 = pDessin.Height / 2f;
            g.DrawLine(styloRouge, 0, axeY0, pDessin.Width, axeY0);

            Pen styloBleu = new Pen(Color.DarkBlue, 2);

            float xPrecedent = 0;

            float yPrecedent = pDessin.Height - (((((MonPoint)alData[0]).Y - minY) * pDessin.Height) / (float)hauteurDonneesY);


            for (int i = 0; i < alData.Count; i++)
            {
                MonPoint p = (MonPoint)alData[i];
                float xPixel = ((p.X - minX) * pDessin.Width) / (float)largeurDonneesX;
                float yPixel = pDessin.Height - (((p.Y - minY) * pDessin.Height) / (float)hauteurDonneesY);

                if (i > 0)
                {
                    g.DrawLine(styloBleu, xPrecedent, yPrecedent, xPixel, yPrecedent);
                    g.DrawLine(styloBleu, xPixel, yPrecedent, xPixel, yPixel);
                }

                xPrecedent = xPixel;
                yPrecedent = yPixel;
            }
        }
    }
}
