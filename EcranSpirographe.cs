using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Fil_Rouge
{
    public partial class EcranSpirographe : Form
    {
        Color cFond = Color.DarkBlue;
        Color cTrait = Color.Cyan;
        GraphicsPath gpSauvegarde = null;

        public EcranSpirographe()
        {
            InitializeComponent();
            gpSauvegarde = null;
        }
 
        private void bFond_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK) cFond = cdCouleur.Color;
            this.Invalidate(); 
        }

        private void bTrait_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK) cTrait = cdCouleur.Color;
            this.Invalidate();
        }
        private void bGo_Click(object sender, EventArgs e)
        {
            gpSauvegarde = new GraphicsPath();
            int iSommets = tbSommets.Value;   
            double iDensite = tbDensite.Value;  
            double iProfondeur = tbProfondeur.Value;

            float xc = (248 + this.ClientSize.Width) / 2f;
            float yc = this.ClientSize.Height / 2f;
            float rayon = Math.Min(this.ClientSize.Width - 248, this.ClientSize.Height) / 2.1f;

            double[] sx = new double[iSommets + 1];
            double[] sy = new double[iSommets + 1];

            for (int i = 0; i <= iSommets; i++)
            {
                sx[i] = xc + rayon * Math.Cos(2 * Math.PI * i / iSommets);
                sy[i] = yc + rayon * Math.Sin(2 * Math.PI * i / iSommets);
            }

            double dist = rayon;
            while (dist > (rayon * iProfondeur / 100.0))
            {
                for (int i = 0; i < iSommets; i++)
                {
                    gpSauvegarde.AddLine((float)sx[i], (float)sy[i], (float)sx[i + 1], (float)sy[i + 1]);
                    sx[i] = sx[i] + (sx[i + 1] - sx[i]) / iDensite;
                    sy[i] = sy[i] + (sy[i + 1] - sy[i]) / iDensite;
                }
                sx[iSommets] = sx[0];
                sy[iSommets] = sy[0];

                dist = Math.Sqrt(Math.Pow(sx[0] - xc, 2) + Math.Pow(sy[0] - yc, 2));
            }
            this.Invalidate(); 
        }
        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(cFond), new Rectangle(new Point(360, 0), this.ClientSize)); 
            if (gpSauvegarde != null)
            {
                 e.Graphics.DrawPath(new Pen(cTrait), gpSauvegarde); 
            }
        }
    }
}