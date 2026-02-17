namespace Fil_Rouge
{
    partial class ucModification
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            tbModif = new TextBox();
            cbModif = new ComboBox();
            lNomModif = new Label();
            lQualiteModif = new Label();
            bConfirmerModif = new Button();
            bAnnulerModif = new Button();
            SuspendLayout();
            // 
            // tbModif
            // 
            tbModif.Location = new Point(28, 40);
            tbModif.Name = "tbModif";
            tbModif.Size = new Size(293, 31);
            tbModif.TabIndex = 0;
            // 
            // cbModif
            // 
            cbModif.FormattingEnabled = true;
            cbModif.Items.AddRange(new object[] { "Madame", "Monsieur", "Mademoiselle", "Flaque d'eau", "Avion de chasse", "Alien" });
            cbModif.Location = new Point(28, 106);
            cbModif.Name = "cbModif";
            cbModif.Size = new Size(293, 33);
            cbModif.TabIndex = 1;
            // 
            // lNomModif
            // 
            lNomModif.AutoSize = true;
            lNomModif.Location = new Point(28, 12);
            lNomModif.Name = "lNomModif";
            lNomModif.Size = new Size(134, 25);
            lNomModif.TabIndex = 2;
            lNomModif.Text = "Nouveau nom :";
            // 
            // lQualiteModif
            // 
            lQualiteModif.AutoSize = true;
            lQualiteModif.Location = new Point(28, 78);
            lQualiteModif.Name = "lQualiteModif";
            lQualiteModif.Size = new Size(148, 25);
            lQualiteModif.TabIndex = 3;
            lQualiteModif.Text = "Nouvelle qualité :";
            // 
            // bConfirmerModif
            // 
            bConfirmerModif.Location = new Point(354, 40);
            bConfirmerModif.Name = "bConfirmerModif";
            bConfirmerModif.Size = new Size(132, 31);
            bConfirmerModif.TabIndex = 4;
            bConfirmerModif.Text = "Confirmer";
            bConfirmerModif.UseVisualStyleBackColor = true;
            bConfirmerModif.Click += bConfirmerModif_Click;
            // 
            // bAnnulerModif
            // 
            bAnnulerModif.Location = new Point(354, 108);
            bAnnulerModif.Name = "bAnnulerModif";
            bAnnulerModif.Size = new Size(132, 31);
            bAnnulerModif.TabIndex = 5;
            bAnnulerModif.Text = "Annuler";
            bAnnulerModif.UseVisualStyleBackColor = true;
            bAnnulerModif.Click += bAnnulerModif_Click;
            // 
            // ucModification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bAnnulerModif);
            Controls.Add(bConfirmerModif);
            Controls.Add(lQualiteModif);
            Controls.Add(lNomModif);
            Controls.Add(cbModif);
            Controls.Add(tbModif);
            Name = "ucModification";
            Size = new Size(519, 165);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbModif;
        public ComboBox cbModif;
        private Label lNomModif;
        private Label lQualiteModif;
        private Button bConfirmerModif;
        private Button bAnnulerModif;
    }
}
