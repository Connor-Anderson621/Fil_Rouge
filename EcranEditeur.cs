using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fil_Rouge
{
    public partial class EcranEditeur : Form
    {
        string sFichier;
        bool bModifier;
        public EcranEditeur()
        {
            InitializeComponent();
        }

        private void EcranEditeur_Load(object sender, EventArgs e)
        {

        }

        private void FichierEnregistrer()
        {
            string TextToWrite = rtbTexte.Text;
            if (sFichier is null)
            {
                sfdEnregistrer.ShowDialog();
                sFichier = sfdEnregistrer.FileName;
            }

            if (File.Exists(sFichier) == false)
            {
                File.Create(sFichier).Close();
            }
            System.IO.File.WriteAllText(sFichier, TextToWrite);

        }

        private void VerifierSauver()
        {
            if (bModifier)
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous enregistrer les modifications ?",
                                                       "Enregistrement",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

                if (reponse == DialogResult.Yes)
                {
                    FichierEnregistrer();
                }
            }
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            bModifier = true;
        }

        private void grasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle styleActuel = rtbTexte.SelectionFont.Style;

                rtbTexte.SelectionBullet = false;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, styleActuel ^ FontStyle.Bold);
            }
        }

        private void italiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle styleActuel = rtbTexte.SelectionFont.Style;

                rtbTexte.SelectionBullet = false;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, styleActuel ^ FontStyle.Italic);
            }
        }

        private void soulignéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle styleActuel = rtbTexte.SelectionFont.Style;

                rtbTexte.SelectionBullet = false;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, styleActuel ^ FontStyle.Underline);
            }
        }

        private void barréToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                FontStyle styleActuel = rtbTexte.SelectionFont.Style;

                rtbTexte.SelectionBullet = false;
                rtbTexte.SelectionFont = new Font(rtbTexte.SelectionFont, styleActuel ^ FontStyle.Strikeout);
            }
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexte.SelectionFont != null)
            {
                fdPolice.ShowDialog();
            }

        }

        private void droiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {

        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }
    }
}
