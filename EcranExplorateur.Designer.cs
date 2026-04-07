using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fil_Rouge
{
    partial class EcranExplorateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            tsCommandes = new ToolStrip();
            tsbQuitter = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsddbApparence = new ToolStripDropDownButton();
            tsaPetitesIcones = new ToolStripMenuItem();
            tsaGrandesIcones = new ToolStripMenuItem();
            tsaListe = new ToolStripMenuItem();
            tsaDetail = new ToolStripMenuItem();
            ssMessage = new StatusStrip();
            slMessage = new ToolStripStatusLabel();
            scSeparateur = new SplitContainer();
            tvRepertoire = new System.Windows.Forms.TreeView();
            ilTreeView = new ImageList(components);
            lvFichiers = new System.Windows.Forms.ListView();
            NOM = new ColumnHeader();
            TAIL = new ColumnHeader();
            CREA = new ColumnHeader();
            MODI = new ColumnHeader();
            ilGrand = new ImageList(components);
            ilPetit = new ImageList(components);
            tsCommandes.SuspendLayout();
            ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scSeparateur).BeginInit();
            scSeparateur.Panel1.SuspendLayout();
            scSeparateur.Panel2.SuspendLayout();
            scSeparateur.SuspendLayout();
            SuspendLayout();
            // 
            // tsCommandes
            // 
            tsCommandes.ImageScalingSize = new Size(20, 20);
            tsCommandes.Items.AddRange(new ToolStripItem[] { tsbQuitter, toolStripSeparator1, tsddbApparence });
            tsCommandes.Location = new Point(0, 0);
            tsCommandes.Name = "tsCommandes";
            tsCommandes.Size = new Size(800, 27);
            tsCommandes.TabIndex = 0;
            tsCommandes.Text = "toolStrip1";
            // 
            // tsbQuitter
            // 
            tsbQuitter.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbQuitter.Image = Properties.Resources.exit;
            tsbQuitter.ImageTransparentColor = Color.Magenta;
            tsbQuitter.Name = "tsbQuitter";
            tsbQuitter.Size = new Size(29, 24);
            tsbQuitter.Text = "Quitter";
            tsbQuitter.Click += tsbQuitter_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsddbApparence
            // 
            tsddbApparence.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsddbApparence.DropDownItems.AddRange(new ToolStripItem[] { tsaPetitesIcones, tsaGrandesIcones, tsaListe, tsaDetail });
            tsddbApparence.Image = Properties.Resources.icons8_parameters_66;
            tsddbApparence.ImageTransparentColor = Color.Magenta;
            tsddbApparence.Name = "tsddbApparence";
            tsddbApparence.Size = new Size(34, 24);
            tsddbApparence.Text = "Apparence";
            // 
            // tsaPetitesIcones
            // 
            tsaPetitesIcones.Name = "tsaPetitesIcones";
            tsaPetitesIcones.Size = new Size(224, 26);
            tsaPetitesIcones.Text = "tsaPetitesIcones";
            tsaPetitesIcones.Click += ChangementVue_Click;
            // 
            // tsaGrandesIcones
            // 
            tsaGrandesIcones.Name = "tsaGrandesIcones";
            tsaGrandesIcones.Size = new Size(224, 26);
            tsaGrandesIcones.Text = "tsaGrandesIcones";
            tsaGrandesIcones.Click += ChangementVue_Click;
            // 
            // tsaListe
            // 
            tsaListe.Name = "tsaListe";
            tsaListe.Size = new Size(224, 26);
            tsaListe.Text = "tsaListe";
            tsaListe.Click += ChangementVue_Click;
            // 
            // tsaDetail
            // 
            tsaDetail.Name = "tsaDetail";
            tsaDetail.Size = new Size(224, 26);
            tsaDetail.Text = "tsaDetail";
            tsaDetail.Click += ChangementVue_Click;
            // 
            // ssMessage
            // 
            ssMessage.ImageScalingSize = new Size(20, 20);
            ssMessage.Items.AddRange(new ToolStripItem[] { slMessage });
            ssMessage.Location = new Point(0, 424);
            ssMessage.Name = "ssMessage";
            ssMessage.Size = new Size(800, 26);
            ssMessage.TabIndex = 0;
            ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            slMessage.Name = "slMessage";
            slMessage.Size = new Size(151, 20);
            slMessage.Text = "toolStripStatusLabel1";
            // 
            // scSeparateur
            // 
            scSeparateur.Dock = DockStyle.Fill;
            scSeparateur.Location = new Point(0, 27);
            scSeparateur.Name = "scSeparateur";
            // 
            // scSeparateur.Panel1
            // 
            scSeparateur.Panel1.Controls.Add(tvRepertoire);
            // 
            // scSeparateur.Panel2
            // 
            scSeparateur.Panel2.Controls.Add(lvFichiers);
            scSeparateur.Size = new Size(800, 397);
            scSeparateur.SplitterDistance = 266;
            scSeparateur.TabIndex = 0;
            // 
            // tvRepertoire
            // 
            tvRepertoire.ImageIndex = 0;
            tvRepertoire.ImageList = ilTreeView;
            tvRepertoire.Location = new Point(3, 3);
            tvRepertoire.Name = "tvRepertoire";
            tvRepertoire.SelectedImageIndex = 0;
            tvRepertoire.Size = new Size(260, 391);
            tvRepertoire.TabIndex = 0;
            tvRepertoire.AfterSelect += tvRepertoire_AfterSelect;
            // 
            // ilTreeView
            // 
            ilTreeView.ColorDepth = ColorDepth.Depth32Bit;
            ilTreeView.ImageStream = (ImageListStreamer)resources.GetObject("ilTreeView.ImageStream");
            ilTreeView.TransparentColor = Color.Transparent;
            ilTreeView.Images.SetKeyName(0, "icons8-pc-48.png");
            ilTreeView.Images.SetKeyName(1, "icons8-hdd-48.png");
            ilTreeView.Images.SetKeyName(2, "icons8-file-folder-48.png");
            ilTreeView.Images.SetKeyName(3, "icons8-folder-24.png");
            // 
            // lvFichiers
            // 
            lvFichiers.Columns.AddRange(new ColumnHeader[] { NOM, TAIL, CREA, MODI });
            lvFichiers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvFichiers.LargeImageList = ilGrand;
            lvFichiers.Location = new Point(3, 3);
            lvFichiers.Name = "lvFichiers";
            lvFichiers.Size = new Size(524, 391);
            lvFichiers.SmallImageList = ilPetit;
            lvFichiers.TabIndex = 0;
            lvFichiers.UseCompatibleStateImageBehavior = false;
            lvFichiers.View = View.Details;
            // 
            // NOM
            // 
            NOM.Text = "Nom";
            // 
            // TAIL
            // 
            TAIL.Text = "Taille";
            // 
            // CREA
            // 
            CREA.Text = "Creation";
            // 
            // MODI
            // 
            MODI.Text = "Modification";
            // 
            // ilGrand
            // 
            ilGrand.ColorDepth = ColorDepth.Depth32Bit;
            ilGrand.ImageStream = (ImageListStreamer)resources.GetObject("ilGrand.ImageStream");
            ilGrand.TransparentColor = Color.Transparent;
            ilGrand.Images.SetKeyName(0, "icons8-file-30.png");
            ilGrand.Images.SetKeyName(1, "icons8-file-folder-48.png");
            // 
            // ilPetit
            // 
            ilPetit.ColorDepth = ColorDepth.Depth32Bit;
            ilPetit.ImageStream = (ImageListStreamer)resources.GetObject("ilPetit.ImageStream");
            ilPetit.TransparentColor = Color.Transparent;
            ilPetit.Images.SetKeyName(0, "icons8-file-30.png");
            ilPetit.Images.SetKeyName(1, "icons8-file-folder-48.png");
            // 
            // EcranExplorateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scSeparateur);
            Controls.Add(ssMessage);
            Controls.Add(tsCommandes);
            Name = "EcranExplorateur";
            Text = "EcranExplorateur";
            tsCommandes.ResumeLayout(false);
            tsCommandes.PerformLayout();
            ssMessage.ResumeLayout(false);
            ssMessage.PerformLayout();
            scSeparateur.Panel1.ResumeLayout(false);
            scSeparateur.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scSeparateur).EndInit();
            scSeparateur.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsCommandes;
        private ToolStripButton tsbQuitter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsddbApparence;
        private ToolStripMenuItem tsaPetitesIcones;
        private ToolStripMenuItem tsaGrandesIcones;
        private ToolStripMenuItem tsaListe;
        private ToolStripMenuItem tsaDetail;
        private StatusStrip ssMessage;
        private ToolStripStatusLabel slMessage;
        private SplitContainer scSeparateur;
        //private TreeView tvRepertoire;
        private ImageList ilTreeView;
        private ImageList ilGrand;
        private ImageList ilPetit;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.ListView lvFichiers;
        private ColumnHeader NOM;
        private ColumnHeader TAIL;
        private ColumnHeader CREA;
        private ColumnHeader MODI;
        //private ListView lvFichiers;
    }
}