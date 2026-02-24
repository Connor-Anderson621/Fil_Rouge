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
        private EcranListe _parent;
        public ucModification()
        {
            InitializeComponent();
        }

        public void Initialiser(EcranListe parent)
        {
            _parent = parent;
        }

        private void bConfirmerModif_Click(object sender, EventArgs e)
        {
            string nomModifie = tbModif.Text;
            string qualiteModifie = cbModif.Text;
            int index = _parent.lbPersonne.SelectedIndex;
            int encodageActuel = EcranListe.SendMessage(_parent.lbPersonne.Handle, 0x0199, index, 0);

            // 2. On modifie le texte
            _parent.lbPersonne.Items[index] = $"{nomModifie} - ({qualiteModifie})";

            // 3. IMPORTANT : Si la liste est triée (Sorted), l'index a pu changer ! 
            // On récupère le nouvel index pour ré-écrire la donnée cachée
            int nouvelIndex = _parent.lbPersonne.Items.IndexOf($"{nomModifie} - ({qualiteModifie})");
            EcranListe.SendMessage(_parent.lbPersonne.Handle, 0x019A, nouvelIndex, encodageActuel);
            this.Hide();
        }

        private void bAnnulerModif_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
