namespace Fil_Rouge
{
    partial class EcranEditeur
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
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            enregistrerToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            editerToolStripMenuItem = new ToolStripMenuItem();
            copierToolStripMenuItem = new ToolStripMenuItem();
            couperToolStripMenuItem = new ToolStripMenuItem();
            collerToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            justifierToolStripMenuItem = new ToolStripMenuItem();
            gaucheToolStripMenuItem = new ToolStripMenuItem();
            centreToolStripMenuItem = new ToolStripMenuItem();
            droiteToolStripMenuItem = new ToolStripMenuItem();
            policeToolStripMenuItem = new ToolStripMenuItem();
            caractèreToolStripMenuItem = new ToolStripMenuItem();
            grasToolStripMenuItem = new ToolStripMenuItem();
            italiqueToolStripMenuItem = new ToolStripMenuItem();
            soulignéToolStripMenuItem = new ToolStripMenuItem();
            barréToolStripMenuItem = new ToolStripMenuItem();
            pMenu = new Panel();
            pbQuitter = new PictureBox();
            pbEnregistrer = new PictureBox();
            pbOuvrir = new PictureBox();
            pbNouveau = new PictureBox();
            rtbTexte = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            fdPolice = new FontDialog();
            menuStrip1.SuspendLayout();
            pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbQuitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, editerToolStripMenuItem, formatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1000, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, enregistrerToolStripMenuItem, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(78, 29);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(198, 34);
            nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(198, 34);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // enregistrerToolStripMenuItem
            // 
            enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            enregistrerToolStripMenuItem.Size = new Size(198, 34);
            enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(198, 34);
            quitterToolStripMenuItem.Text = "Quitter";
            // 
            // editerToolStripMenuItem
            // 
            editerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copierToolStripMenuItem, couperToolStripMenuItem, collerToolStripMenuItem });
            editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            editerToolStripMenuItem.Size = new Size(73, 29);
            editerToolStripMenuItem.Text = "Editer";
            // 
            // copierToolStripMenuItem
            // 
            copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            copierToolStripMenuItem.Size = new Size(172, 34);
            copierToolStripMenuItem.Text = "Copier";
            // 
            // couperToolStripMenuItem
            // 
            couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            couperToolStripMenuItem.Size = new Size(172, 34);
            couperToolStripMenuItem.Text = "Couper";
            // 
            // collerToolStripMenuItem
            // 
            collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            collerToolStripMenuItem.Size = new Size(172, 34);
            collerToolStripMenuItem.Text = "Coller";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { justifierToolStripMenuItem, policeToolStripMenuItem, caractèreToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(85, 29);
            formatToolStripMenuItem.Text = "Format";
            // 
            // justifierToolStripMenuItem
            // 
            justifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gaucheToolStripMenuItem, centreToolStripMenuItem, droiteToolStripMenuItem });
            justifierToolStripMenuItem.Name = "justifierToolStripMenuItem";
            justifierToolStripMenuItem.Size = new Size(187, 34);
            justifierToolStripMenuItem.Text = "Justifier";
            // 
            // gaucheToolStripMenuItem
            // 
            gaucheToolStripMenuItem.Name = "gaucheToolStripMenuItem";
            gaucheToolStripMenuItem.Size = new Size(172, 34);
            gaucheToolStripMenuItem.Text = "Gauche";
            // 
            // centreToolStripMenuItem
            // 
            centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            centreToolStripMenuItem.Size = new Size(172, 34);
            centreToolStripMenuItem.Text = "Centre";
            // 
            // droiteToolStripMenuItem
            // 
            droiteToolStripMenuItem.Name = "droiteToolStripMenuItem";
            droiteToolStripMenuItem.Size = new Size(172, 34);
            droiteToolStripMenuItem.Text = "Droite";
            droiteToolStripMenuItem.Click += droiteToolStripMenuItem_Click;
            // 
            // policeToolStripMenuItem
            // 
            policeToolStripMenuItem.Name = "policeToolStripMenuItem";
            policeToolStripMenuItem.Size = new Size(187, 34);
            policeToolStripMenuItem.Text = "Police";
            policeToolStripMenuItem.Click += policeToolStripMenuItem_Click;
            // 
            // caractèreToolStripMenuItem
            // 
            caractèreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grasToolStripMenuItem, italiqueToolStripMenuItem, soulignéToolStripMenuItem, barréToolStripMenuItem });
            caractèreToolStripMenuItem.Name = "caractèreToolStripMenuItem";
            caractèreToolStripMenuItem.Size = new Size(187, 34);
            caractèreToolStripMenuItem.Text = "Caractère";
            // 
            // grasToolStripMenuItem
            // 
            grasToolStripMenuItem.Name = "grasToolStripMenuItem";
            grasToolStripMenuItem.Size = new Size(183, 34);
            grasToolStripMenuItem.Text = "Gras";
            grasToolStripMenuItem.Click += grasToolStripMenuItem_Click;
            // 
            // italiqueToolStripMenuItem
            // 
            italiqueToolStripMenuItem.Name = "italiqueToolStripMenuItem";
            italiqueToolStripMenuItem.Size = new Size(183, 34);
            italiqueToolStripMenuItem.Text = "Italique";
            italiqueToolStripMenuItem.Click += italiqueToolStripMenuItem_Click;
            // 
            // soulignéToolStripMenuItem
            // 
            soulignéToolStripMenuItem.Name = "soulignéToolStripMenuItem";
            soulignéToolStripMenuItem.Size = new Size(183, 34);
            soulignéToolStripMenuItem.Text = "Souligné";
            soulignéToolStripMenuItem.Click += soulignéToolStripMenuItem_Click;
            // 
            // barréToolStripMenuItem
            // 
            barréToolStripMenuItem.Name = "barréToolStripMenuItem";
            barréToolStripMenuItem.Size = new Size(183, 34);
            barréToolStripMenuItem.Text = "Barré";
            barréToolStripMenuItem.Click += barréToolStripMenuItem_Click;
            // 
            // pMenu
            // 
            pMenu.BackColor = SystemColors.ControlLight;
            pMenu.Controls.Add(pbQuitter);
            pMenu.Controls.Add(pbEnregistrer);
            pMenu.Controls.Add(pbOuvrir);
            pMenu.Controls.Add(pbNouveau);
            pMenu.Controls.Add(rtbTexte);
            pMenu.Dock = DockStyle.Bottom;
            pMenu.Location = new Point(0, 36);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(1000, 526);
            pMenu.TabIndex = 2;
            // 
            // pbQuitter
            // 
            pbQuitter.BackgroundImageLayout = ImageLayout.None;
            pbQuitter.Image = Properties.Resources.exit;
            pbQuitter.Location = new Point(138, 3);
            pbQuitter.Name = "pbQuitter";
            pbQuitter.Size = new Size(36, 36);
            pbQuitter.SizeMode = PictureBoxSizeMode.Zoom;
            pbQuitter.TabIndex = 4;
            pbQuitter.TabStop = false;
            // 
            // pbEnregistrer
            // 
            pbEnregistrer.BackgroundImageLayout = ImageLayout.None;
            pbEnregistrer.Image = Properties.Resources.saveDoc;
            pbEnregistrer.Location = new Point(96, 3);
            pbEnregistrer.Name = "pbEnregistrer";
            pbEnregistrer.Size = new Size(36, 36);
            pbEnregistrer.SizeMode = PictureBoxSizeMode.Zoom;
            pbEnregistrer.TabIndex = 3;
            pbEnregistrer.TabStop = false;
            pbEnregistrer.Click += pbEnregistrer_Click;
            // 
            // pbOuvrir
            // 
            pbOuvrir.BackgroundImageLayout = ImageLayout.None;
            pbOuvrir.Image = Properties.Resources.openDoc;
            pbOuvrir.Location = new Point(54, 3);
            pbOuvrir.Name = "pbOuvrir";
            pbOuvrir.Size = new Size(36, 36);
            pbOuvrir.SizeMode = PictureBoxSizeMode.Zoom;
            pbOuvrir.TabIndex = 2;
            pbOuvrir.TabStop = false;
            // 
            // pbNouveau
            // 
            pbNouveau.BackgroundImageLayout = ImageLayout.None;
            pbNouveau.Image = Properties.Resources.newdooc;
            pbNouveau.Location = new Point(12, 3);
            pbNouveau.Name = "pbNouveau";
            pbNouveau.Size = new Size(36, 36);
            pbNouveau.SizeMode = PictureBoxSizeMode.Zoom;
            pbNouveau.TabIndex = 1;
            pbNouveau.TabStop = false;
            pbNouveau.Click += pbNouveau_Click;
            // 
            // rtbTexte
            // 
            rtbTexte.Dock = DockStyle.Bottom;
            rtbTexte.Location = new Point(0, 43);
            rtbTexte.Name = "rtbTexte";
            rtbTexte.Size = new Size(1000, 483);
            rtbTexte.TabIndex = 0;
            rtbTexte.Text = "";
            rtbTexte.TextChanged += rtbTexte_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "ofdOuvrir";
            // 
            // EcranEditeur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(pMenu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "EcranEditeur";
            Text = "EcranEditeur";
            Load += EcranEditeur_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbQuitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnregistrer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOuvrir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNouveau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem enregistrerToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem editerToolStripMenuItem;
        private ToolStripMenuItem copierToolStripMenuItem;
        private ToolStripMenuItem couperToolStripMenuItem;
        private ToolStripMenuItem collerToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem justifierToolStripMenuItem;
        private ToolStripMenuItem gaucheToolStripMenuItem;
        private ToolStripMenuItem centreToolStripMenuItem;
        private ToolStripMenuItem droiteToolStripMenuItem;
        private ToolStripMenuItem policeToolStripMenuItem;
        private ToolStripMenuItem caractèreToolStripMenuItem;
        private ToolStripMenuItem grasToolStripMenuItem;
        private ToolStripMenuItem italiqueToolStripMenuItem;
        private ToolStripMenuItem soulignéToolStripMenuItem;
        private ToolStripMenuItem barréToolStripMenuItem;
        private Panel pMenu;
        private RichTextBox rtbTexte;
        private PictureBox pbNouveau;
        private PictureBox pbEnregistrer;
        private PictureBox pbOuvrir;
        private PictureBox pbQuitter;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog sfdEnregistrer;
        private FontDialog fdPolice;
    }
}