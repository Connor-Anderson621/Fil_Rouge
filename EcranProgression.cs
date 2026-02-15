using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fil_Rouge
{
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bExecuter_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bExecuter.Enabled = false;

            Random rnd = new Random();
            int nbFichiers = rnd.Next(5, 11);

            pbPrincipal.Maximum = nbFichiers;
            pbPrincipal.Value = 0;

            for (int i = 0; i < nbFichiers; i++)
            {
                int tailleFichier = rnd.Next(10, 51);
                pbSecondaire.Maximum = tailleFichier;
                pbSecondaire.Value = 0;

                for (int j = 0; j < tailleFichier; j++)
                {
                    pbSecondaire.Value++;
                    // NE bloque PAS le thread UI
                    await Task.Delay(50);
                }
                pbPrincipal.Value++;
            }

            Cursor = Cursors.Default;
            bExecuter.Enabled = true;
        }
    }
}
