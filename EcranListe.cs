using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fil_Rouge
{
    public partial class EcranListe : Form
    {
        private string NomFichier = @"C:\Users\Cyril\Documents\_Fichiers_labo1\noms.txt";

        public EcranListe()
        {
            InitializeComponent();
        }
        public void Activer(int activation)
        {
            bool ButtonToggle;

            if (activation == 1)
            {
                ButtonToggle = true;
            }
            else
            {
                ButtonToggle = false;
            }

            if (ButtonToggle == true)
            {
                gbDetail.Enabled = false;
                cbQualite.Enabled = false;

                bOuvrir.Enabled = true;
                bEnregistrer.Enabled = true;
                bAjouter.Enabled = true;
                bSupprimer.Enabled = true;
                lbPersonne.Enabled = true;
            }
            else
            {
                gbDetail.Enabled = true;
                cbQualite.Enabled = true;

                bOuvrir.Enabled = false;
                bEnregistrer.Enabled = false;
                bAjouter.Enabled = false;
                bSupprimer.Enabled = false;
                lbPersonne.Enabled = false;
            }
        }



        private void bOuvrir_Click(object sender, EventArgs e)
        {
            ofdOuvrir.ShowDialog();
            ofdOuvrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string NomFichier = ofdOuvrir.FileName;
            File.ReadLines(NomFichier).ToList().ForEach(line => lbPersonne.Items.Add(line));
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            sfdEnregistrer.ShowDialog();
            string NomFichier = sfdEnregistrer.FileName;
            if (File.Exists(NomFichier) == false)
            {
                File.Create(NomFichier).Close();
            }
            foreach (var item in lbPersonne.Items)
            {
                string lignetemp = item.ToString() + Environment.NewLine;
                System.IO.File.AppendAllText(NomFichier, lignetemp);
            }

        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            Activer(0);
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            Activer(1);
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            string nom = tbNom.Text;
            string qualite = cbQualite.SelectedItem.ToString();

            lbPersonne.Items.Add($"{nom} - ({qualite})");
            //Activer(1);
        }
        private void ItemClicked(object sender, EventArgs e)
        {
           if (lbPersonne.SelectedItem != null)
            {
                string selectedItem = lbPersonne.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new string[] { " - (" }, StringSplitOptions.None);
            }
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (lbPersonne.SelectedItem != null)
            {
                lbPersonne.Items.Remove(lbPersonne.SelectedItem);
            }
        }
    }
}
