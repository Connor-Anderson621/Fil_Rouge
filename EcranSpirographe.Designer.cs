namespace Fil_Rouge
{
    partial class EcranSpirographe
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
            gbParametrage = new GroupBox();
            bGo = new Button();
            lProfondeur = new Label();
            lDensite = new Label();
            tbProfondeur = new TrackBar();
            tbDensite = new TrackBar();
            lSommets = new Label();
            tbSommets = new TrackBar();
            bTrait = new Button();
            bFond = new Button();
            cdCouleur = new ColorDialog();
            gbParametrage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).BeginInit();
            SuspendLayout();
            // 
            // gbParametrage
            // 
            gbParametrage.Controls.Add(bGo);
            gbParametrage.Controls.Add(lProfondeur);
            gbParametrage.Controls.Add(lDensite);
            gbParametrage.Controls.Add(tbProfondeur);
            gbParametrage.Controls.Add(tbDensite);
            gbParametrage.Controls.Add(lSommets);
            gbParametrage.Controls.Add(tbSommets);
            gbParametrage.Location = new Point(15, 15);
            gbParametrage.Margin = new Padding(4, 4, 4, 4);
            gbParametrage.Name = "gbParametrage";
            gbParametrage.Padding = new Padding(4, 4, 4, 4);
            gbParametrage.Size = new Size(342, 406);
            gbParametrage.TabIndex = 0;
            gbParametrage.TabStop = false;
            gbParametrage.Text = "Paramétrage";
            // 
            // bGo
            // 
            bGo.Location = new Point(8, 332);
            bGo.Margin = new Padding(4, 4, 4, 4);
            bGo.Name = "bGo";
            bGo.Size = new Size(328, 54);
            bGo.TabIndex = 6;
            bGo.Text = "GO !";
            bGo.UseVisualStyleBackColor = true;
            bGo.Click += bGo_Click;
            // 
            // lProfondeur
            // 
            lProfondeur.AutoSize = true;
            lProfondeur.Location = new Point(8, 240);
            lProfondeur.Margin = new Padding(4, 0, 4, 0);
            lProfondeur.Name = "lProfondeur";
            lProfondeur.Size = new Size(256, 25);
            lProfondeur.TabIndex = 5;
            lProfondeur.Text = "Profondeur de dessin (20 à 80)";
            // 
            // lDensite
            // 
            lDensite.AutoSize = true;
            lDensite.Location = new Point(8, 136);
            lDensite.Margin = new Padding(4, 0, 4, 0);
            lDensite.Name = "lDensite";
            lDensite.Size = new Size(223, 25);
            lDensite.TabIndex = 4;
            lDensite.Text = "Densité de dessins (5 à 20)";
            // 
            // tbProfondeur
            // 
            tbProfondeur.Location = new Point(8, 269);
            tbProfondeur.Margin = new Padding(4, 4, 4, 4);
            tbProfondeur.Maximum = 80;
            tbProfondeur.Minimum = 20;
            tbProfondeur.Name = "tbProfondeur";
            tbProfondeur.Size = new Size(320, 69);
            tbProfondeur.TabIndex = 7;
            tbProfondeur.Value = 20;
            // 
            // tbDensite
            // 
            tbDensite.Location = new Point(8, 166);
            tbDensite.Margin = new Padding(4, 4, 4, 4);
            tbDensite.Maximum = 20;
            tbDensite.Minimum = 5;
            tbDensite.Name = "tbDensite";
            tbDensite.Size = new Size(320, 69);
            tbDensite.TabIndex = 8;
            tbDensite.Value = 5;
            // 
            // lSommets
            // 
            lSommets.AutoSize = true;
            lSommets.Location = new Point(8, 29);
            lSommets.Margin = new Padding(4, 0, 4, 0);
            lSommets.Name = "lSommets";
            lSommets.Size = new Size(236, 25);
            lSommets.TabIndex = 3;
            lSommets.Text = "Nombre de sommets (3 à 8)";
            // 
            // tbSommets
            // 
            tbSommets.Location = new Point(0, 62);
            tbSommets.Margin = new Padding(4, 4, 4, 4);
            tbSommets.Maximum = 8;
            tbSommets.Minimum = 3;
            tbSommets.Name = "tbSommets";
            tbSommets.Size = new Size(328, 69);
            tbSommets.TabIndex = 0;
            tbSommets.Value = 3;
            // 
            // bTrait
            // 
            bTrait.Location = new Point(15, 441);
            bTrait.Margin = new Padding(4, 4, 4, 4);
            bTrait.Name = "bTrait";
            bTrait.Size = new Size(166, 59);
            bTrait.TabIndex = 1;
            bTrait.Text = "Trait";
            bTrait.UseVisualStyleBackColor = true;
            bTrait.Click += bTrait_Click;
            // 
            // bFond
            // 
            bFond.Location = new Point(189, 441);
            bFond.Margin = new Padding(4, 4, 4, 4);
            bFond.Name = "bFond";
            bFond.Size = new Size(166, 59);
            bFond.TabIndex = 2;
            bFond.Text = "Fond";
            bFond.UseVisualStyleBackColor = true;
            bFond.Click += bFond_Click;
            // 
            // EcranSpirographe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 522);
            Controls.Add(bFond);
            Controls.Add(bTrait);
            Controls.Add(gbParametrage);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EcranSpirographe";
            Text = "EcranSpirographe";
            Paint += EcranSpirographe_Paint;
            gbParametrage.ResumeLayout(false);
            gbParametrage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbProfondeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDensite).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSommets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbParametrage;
        private TrackBar tbSommets;
        private TrackBar tbProfondeur;
        private TrackBar tbDensite;
        private Label lSommets;
        private Label lDensite;
        private Label lProfondeur;
        private Button bGo;
        private Button bTrait;
        private Button bFond;
        private ColorDialog cdCouleur;
    }
}