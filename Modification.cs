using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fil_Rouge
{
    public partial class ucModification : UserControl
    {
        public ucModification()
        {
            InitializeComponent();
        }

        private void bConfirmerModif_Click(object sender, EventArgs e)
        {
            string nomModifie = tbModif.Text;
            string qualiteModifie = cbModif.Text;
            int index = EcranListe.lbPersonne.SelectedIndex;
            EcranListe.lbPersonne.Items[index] = $"{nomModifie} - ({qualiteModifie})";
            this.Hide();
        }

        private void bAnnulerModif_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
