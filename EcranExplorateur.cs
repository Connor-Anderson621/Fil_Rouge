using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fil_Rouge
{
    public partial class EcranExplorateur : Form
    {
        public EcranExplorateur()
        {
            InitializeComponent();
            RemplirTreeView(); 
        }

        private void RemplirTreeView()
        {
            tvRepertoire.Nodes.Clear();
            TreeNode racine = new TreeNode("Poste de Travail", 0, 0); 
            tvRepertoire.Nodes.Add(racine);
            LireDisques(racine);
            racine.Expand(); 
        }

        private void LireDisques(TreeNode parent)
        {
            foreach (string disque in Environment.GetLogicalDrives())
            {
                TreeNode noeudDisque = new TreeNode(disque, 1, 1);
                parent.Nodes.Add(noeudDisque);
                LireRepertoires(noeudDisque); 
            }
        }

        private void LireRepertoires(TreeNode parent)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(parent.FullPath.Replace("Poste de Travail\\", "")))
                {
                    TreeNode noeudDir = new TreeNode(Path.GetFileName(dir), 2, 3);
                    parent.Nodes.Add(noeudDir);
                }
            }
            catch { /* Ignore les dossiers protégés */ }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string chemin = e.Node.FullPath.Replace("Poste de Travail\\", "");
            if (Directory.Exists(chemin)) LireFichiers(chemin);
        }

        private void LireFichiers(string chemin)
        {
            lvFichiers.Items.Clear();
            try
            {
                foreach (string fichier in Directory.GetFiles(chemin))
                {
                    FileInfo infos = new FileInfo(fichier); 
                    ListViewItem item = new ListViewItem(infos.Name, 0);
                    item.SubItems.Add((infos.Length / 1024).ToString() + " Ko");
                    item.SubItems.Add(infos.CreationTime.ToShortDateString());   
                    item.SubItems.Add(infos.LastWriteTime.ToShortDateString());  
                    lvFichiers.Items.Add(item);
                }
                slMessage.Text = lvFichiers.Items.Count + " fichier(s) trouvé(s)"; 
            }
            catch (Exception ex) { slMessage.Text = "Erreur : " + ex.Message; }
        }

        private void tsbQuitter_Click(object sender, EventArgs e) => this.Close(); 

        private void ChangementVue_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item == tsaDetail) lvFichiers.View = View.Details; 
            else if (item == tsaGrandesIcones) lvFichiers.View = View.LargeIcon;
            else if (item == tsaPetitesIcones) lvFichiers.View = View.SmallIcon;
            else if (item == tsaListe) lvFichiers.View = View.List;
        }
    }
}
