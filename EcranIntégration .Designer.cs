namespace Fil_Rouge
{
    partial class EcranIntégration
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
            lGauche = new Label();
            LDroite = new Label();
            lNbInt = new Label();
            tbGauche = new TextBox();
            tbDroite = new TextBox();
            tbNbInt = new TextBox();
            lbResultats = new ListBox();
            bPolynome = new Button();
            bTrigonometrique = new Button();
            bPointeurPolynome = new Button();
            bPointeurTrigonometrique = new Button();
            SuspendLayout();
            // 
            // lGauche
            // 
            lGauche.AutoSize = true;
            lGauche.Location = new Point(12, 9);
            lGauche.Name = "lGauche";
            lGauche.Size = new Size(58, 20);
            lGauche.TabIndex = 0;
            lGauche.Text = "Gauche";
            // 
            // LDroite
            // 
            LDroite.AutoSize = true;
            LDroite.Location = new Point(140, 9);
            LDroite.Name = "LDroite";
            LDroite.Size = new Size(51, 20);
            LDroite.TabIndex = 1;
            LDroite.Text = "Droite";
            // 
            // lNbInt
            // 
            lNbInt.AutoSize = true;
            lNbInt.Location = new Point(267, 9);
            lNbInt.Name = "lNbInt";
            lNbInt.Size = new Size(100, 20);
            lNbInt.TabIndex = 2;
            lNbInt.Text = "Nb Intervalles";
            // 
            // tbGauche
            // 
            tbGauche.Location = new Point(12, 32);
            tbGauche.Name = "tbGauche";
            tbGauche.Size = new Size(100, 27);
            tbGauche.TabIndex = 3;
            // 
            // tbDroite
            // 
            tbDroite.Location = new Point(140, 32);
            tbDroite.Name = "tbDroite";
            tbDroite.Size = new Size(100, 27);
            tbDroite.TabIndex = 4;
            // 
            // tbNbInt
            // 
            tbNbInt.Location = new Point(267, 32);
            tbNbInt.Name = "tbNbInt";
            tbNbInt.Size = new Size(100, 27);
            tbNbInt.TabIndex = 5;
            // 
            // lbResultats
            // 
            lbResultats.FormattingEnabled = true;
            lbResultats.Location = new Point(12, 65);
            lbResultats.Name = "lbResultats";
            lbResultats.Size = new Size(355, 324);
            lbResultats.TabIndex = 6;
            // 
            // bPolynome
            // 
            bPolynome.Location = new Point(12, 401);
            bPolynome.Name = "bPolynome";
            bPolynome.Size = new Size(179, 47);
            bPolynome.TabIndex = 7;
            bPolynome.Text = "Polynome : x * x +2";
            bPolynome.UseVisualStyleBackColor = true;
            bPolynome.Click += bPolynome_Click;
            // 
            // bTrigonometrique
            // 
            bTrigonometrique.Location = new Point(12, 454);
            bTrigonometrique.Name = "bTrigonometrique";
            bTrigonometrique.Size = new Size(179, 47);
            bTrigonometrique.TabIndex = 8;
            bTrigonometrique.Text = "Trigonométrique : sin(x)";
            bTrigonometrique.UseVisualStyleBackColor = true;
            bTrigonometrique.Click += bTrigonometrique_Click;
            // 
            // bPointeurPolynome
            // 
            bPointeurPolynome.Location = new Point(197, 401);
            bPointeurPolynome.Name = "bPointeurPolynome";
            bPointeurPolynome.Size = new Size(170, 47);
            bPointeurPolynome.TabIndex = 9;
            bPointeurPolynome.Text = "Idem Pointeur";
            bPointeurPolynome.UseVisualStyleBackColor = true;
            bPointeurPolynome.Click += bPointeurPolynome_Click;
            // 
            // bPointeurTrigonometrique
            // 
            bPointeurTrigonometrique.Location = new Point(197, 454);
            bPointeurTrigonometrique.Name = "bPointeurTrigonometrique";
            bPointeurTrigonometrique.Size = new Size(170, 47);
            bPointeurTrigonometrique.TabIndex = 10;
            bPointeurTrigonometrique.Text = "Idem Pointeur";
            bPointeurTrigonometrique.UseVisualStyleBackColor = true;
            bPointeurTrigonometrique.Click += bPointeurTrigonometrique_Click;
            // 
            // EcranIntégration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 513);
            Controls.Add(bPointeurTrigonometrique);
            Controls.Add(bPointeurPolynome);
            Controls.Add(bTrigonometrique);
            Controls.Add(bPolynome);
            Controls.Add(lbResultats);
            Controls.Add(tbNbInt);
            Controls.Add(tbDroite);
            Controls.Add(tbGauche);
            Controls.Add(lNbInt);
            Controls.Add(LDroite);
            Controls.Add(lGauche);
            Name = "EcranIntégration";
            Text = "EcranIntégration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lGauche;
        private Label LDroite;
        private Label lNbInt;
        private TextBox tbGauche;
        private TextBox tbDroite;
        private TextBox tbNbInt;
        private ListBox lbResultats;
        private Button bPolynome;
        private Button bTrigonometrique;
        private Button bPointeurPolynome;
        private Button bPointeurTrigonometrique;
    }
}