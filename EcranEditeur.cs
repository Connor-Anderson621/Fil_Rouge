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

        private bool FichierEnregistrer()
        {
            if (string.IsNullOrEmpty(sFichier))
            {
                if (sfdEnregistrer.ShowDialog() == DialogResult.OK)
                {
                    sFichier = sfdEnregistrer.FileName;
                }
                else
                {
                    return false; 
                }
            }
            rtbTexte.SaveFile(sFichier);
            bModifier = false;
            return true;

            /*
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
            bModifier = false;
            */

        }

        private bool VerifierSauver()
        {
            if (bModifier==true)
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous enregistrer les modifications ?",
                                                       "Enregistrement",
                                                       MessageBoxButtons.YesNoCancel,
                                                       MessageBoxIcon.Question);

                if (reponse == DialogResult.Yes)
                {
                    return FichierEnregistrer();
                }
                else if (reponse == DialogResult.No)
                {
                    return true; 
                }
                else { return false; }
            }
            return true;
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
                rtbTexte.SelectionFont = fdPolice.Font;
            }

        }

        private void pbNouveau_Click(object sender, EventArgs e)
        {

            if (VerifierSauver())
            {
                rtbTexte.Clear(); 
                sFichier = null; 
                bModifier = false; 
            }

            /*
            if (string.IsNullOrEmpty(rtbTexte.Text))
            {
                bModifier = false;
            }
            VerifierSauver();
            if (VerifierSauver.Dialogresult) 
            {
                rtbTexte.Text = string.Empty;
            }
            */
        }

        private void pbEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void pbOuvrir_Click(object sender, EventArgs e)
        {
            if (VerifierSauver())
            {
                if (ofdOuvrir.ShowDialog() == DialogResult.OK)
                {
                    sFichier = ofdOuvrir.FileName;
                    rtbTexte.LoadFile(sFichier);
                    bModifier = false;
                }
            }



            /*
            if (VerifierSauver() == false)
            { ofdOuvrir.ShowDialog(); }
            if (ofdOuvrir.FileName != "") 
            { 
                string contenuFichier = File.ReadAllText(ofdOuvrir.FileName);
                rtbTexte.Text = contenuFichier;
            }
            */

        }

        private void pbQuitter_Click(object sender, EventArgs e)
        {
            if (VerifierSauver() == true)
            {
                this.Close();
            }
        }

        private void gaucheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void droiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }
    }
}
