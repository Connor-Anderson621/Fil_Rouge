namespace Fil_Rouge
{
    partial class EcranListe
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
            bOuvrir = new Button();
            bEnregistrer = new Button();
            bSupprimer = new Button();
            bAjouter = new Button();
            bConfirmer = new Button();
            bAnnuler = new Button();
            lbPersonne = new ListBox();
            cbQualite = new ComboBox();
            gbDetail = new GroupBox();
            lNom = new Label();
            lQualite = new Label();
            tbNom = new TextBox();
            lFichier = new Label();
            ofdOuvrir = new OpenFileDialog();
            sfdEnregistrer = new SaveFileDialog();
            chkbxOverwrite = new CheckBox();
            gbDetail.SuspendLayout();
            SuspendLayout();
            // 
            // bOuvrir
            // 
            bOuvrir.Location = new Point(12, 233);
            bOuvrir.Name = "bOuvrir";
            bOuvrir.Size = new Size(168, 34);
            bOuvrir.TabIndex = 0;
            bOuvrir.Text = "Ouvrir";
            bOuvrir.UseVisualStyleBackColor = true;
            bOuvrir.Click += bOuvrir_Click;
            // 
            // bEnregistrer
            // 
            bEnregistrer.Location = new Point(12, 273);
            bEnregistrer.Name = "bEnregistrer";
            bEnregistrer.Size = new Size(168, 34);
            bEnregistrer.TabIndex = 1;
            bEnregistrer.Text = "Enregistrer";
            bEnregistrer.UseVisualStyleBackColor = true;
            bEnregistrer.Click += bEnregistrer_Click;
            // 
            // bSupprimer
            // 
            bSupprimer.Location = new Point(12, 381);
            bSupprimer.Name = "bSupprimer";
            bSupprimer.Size = new Size(168, 34);
            bSupprimer.TabIndex = 2;
            bSupprimer.Text = "Supprimer";
            bSupprimer.UseVisualStyleBackColor = true;
            bSupprimer.Click += bSupprimer_Click;
            // 
            // bAjouter
            // 
            bAjouter.Location = new Point(12, 341);
            bAjouter.Name = "bAjouter";
            bAjouter.Size = new Size(168, 34);
            bAjouter.TabIndex = 3;
            bAjouter.Text = "Ajouter";
            bAjouter.UseVisualStyleBackColor = true;
            bAjouter.Click += bAjouter_Click;
            // 
            // bConfirmer
            // 
            bConfirmer.Location = new Point(6, 177);
            bConfirmer.Name = "bConfirmer";
            bConfirmer.Size = new Size(149, 34);
            bConfirmer.TabIndex = 4;
            bConfirmer.Text = "Confirmer";
            bConfirmer.UseVisualStyleBackColor = true;
            bConfirmer.Click += bConfirmer_Click;
            // 
            // bAnnuler
            // 
            bAnnuler.Location = new Point(176, 177);
            bAnnuler.Name = "bAnnuler";
            bAnnuler.Size = new Size(149, 34);
            bAnnuler.TabIndex = 5;
            bAnnuler.Text = "Annuler";
            bAnnuler.UseVisualStyleBackColor = true;
            bAnnuler.Click += bAnnuler_Click;
            // 
            // lbPersonne
            // 
            lbPersonne.FormattingEnabled = true;
            lbPersonne.ItemHeight = 25;
            lbPersonne.Location = new Point(12, 28);
            lbPersonne.Name = "lbPersonne";
            lbPersonne.Size = new Size(537, 179);
            lbPersonne.TabIndex = 6;
            lbPersonne.DoubleClick += ItemClicked;
            // 
            // cbQualite
            // 
            cbQualite.FormattingEnabled = true;
            cbQualite.Items.AddRange(new object[] { "Madame", "Monsieur", "Mademoiselle", "Flaque d'eau", "Avion de chasse", "Alien" });
            cbQualite.Location = new Point(224, 273);
            cbQualite.Name = "cbQualite";
            cbQualite.Size = new Size(319, 33);
            cbQualite.TabIndex = 7;
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(lNom);
            gbDetail.Controls.Add(lQualite);
            gbDetail.Controls.Add(tbNom);
            gbDetail.Controls.Add(bConfirmer);
            gbDetail.Controls.Add(bAnnuler);
            gbDetail.Enabled = false;
            gbDetail.Location = new Point(218, 213);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(331, 226);
            gbDetail.TabIndex = 8;
            gbDetail.TabStop = false;
            gbDetail.Text = "Détail personne";
            // 
            // lNom
            // 
            lNom.AutoSize = true;
            lNom.Location = new Point(6, 100);
            lNom.Name = "lNom";
            lNom.Size = new Size(52, 25);
            lNom.TabIndex = 6;
            lNom.Text = "Nom";
            // 
            // lQualite
            // 
            lQualite.AutoSize = true;
            lQualite.Location = new Point(6, 29);
            lQualite.Name = "lQualite";
            lQualite.Size = new Size(68, 25);
            lQualite.TabIndex = 1;
            lQualite.Text = "Qualité";
            // 
            // tbNom
            // 
            tbNom.Location = new Point(6, 128);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(319, 31);
            tbNom.TabIndex = 0;
            // 
            // lFichier
            // 
            lFichier.AutoSize = true;
            lFichier.Location = new Point(12, 0);
            lFichier.Name = "lFichier";
            lFichier.Size = new Size(129, 25);
            lFichier.TabIndex = 9;
            lFichier.Text = "Nom de fichier";
            // 
            // ofdOuvrir
            // 
            ofdOuvrir.FileName = "ofdOuvrir";
            // 
            // chkbxOverwrite
            // 
            chkbxOverwrite.AutoSize = true;
            chkbxOverwrite.BackColor = SystemColors.ControlLight;
            chkbxOverwrite.Location = new Point(12, 309);
            chkbxOverwrite.Name = "chkbxOverwrite";
            chkbxOverwrite.Size = new Size(114, 29);
            chkbxOverwrite.TabIndex = 10;
            chkbxOverwrite.Text = "Overwrite";
            chkbxOverwrite.UseVisualStyleBackColor = false;
            chkbxOverwrite.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // EcranListe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 451);
            Controls.Add(chkbxOverwrite);
            Controls.Add(lFichier);
            Controls.Add(cbQualite);
            Controls.Add(lbPersonne);
            Controls.Add(bAjouter);
            Controls.Add(bSupprimer);
            Controls.Add(bEnregistrer);
            Controls.Add(bOuvrir);
            Controls.Add(gbDetail);
            Name = "EcranListe";
            Text = "EcranListe";
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bOuvrir;
        private Button bEnregistrer;
        private Button bSupprimer;
        private Button bAjouter;
        private Button bConfirmer;
        private Button bAnnuler;
        private ListBox lbPersonne;
        private ComboBox cbQualite;
        private GroupBox gbDetail;
        private TextBox tbNom;
        private Label lQualite;
        private Label lFichier;
        private Label lNom;
        private OpenFileDialog ofdOuvrir;
        private SaveFileDialog sfdEnregistrer;
        private CheckBox chkbxOverwrite;
    }
}