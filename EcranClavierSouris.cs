using System;
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
    public partial class EcranClavierSouris : Form
    {
        int nbGauche = 0;
        int nbDroit = 0;

        public EcranClavierSouris()
        {
            InitializeComponent();
            // Sert à intercepter une pression de touche sur toute la fenêtre quand en focus
            this.KeyPreview = true;
        }

        private void AfficherClic()
        {
            tbxClicGauche.Text = nbGauche.ToString();
            tbxClicDroit.Text = nbDroit.ToString();
        }

        private void butRAZ_Click(object sender, EventArgs e)
        {
            nbGauche = 0;
            nbDroit = 0;
            AfficherClic();
            tbxPositionX.Text = "0";
            tbxPositionY.Text = "0";
            lsbClavier.Items.Clear();
        }
        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            lsbClavier.Items.Insert(0,e.KeyChar);
        }

        private void pnlSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbxPositionX.Text = e.X.ToString();
            tbxPositionY.Text = e.Y.ToString();
        }

        private void pnlSouris_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) nbGauche++;
            if (e.Button == MouseButtons.Right) nbDroit++;
            AfficherClic();

            int col = (e.X * 3 / pnlSouris.Width) + 1;
            int lig = (e.Y * 3 / pnlSouris.Height) + 1;

            lsbClavier.Items.Insert(0, "X :  " + lig + ", Y : " + col);
        }
    }
}
