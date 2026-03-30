namespace Fil_Rouge
{
    partial class EcranClavierSouris
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
            pnlSouris = new Panel();
            lsbClavier = new ListBox();
            butRAZ = new Button();
            tbxClicGauche = new TextBox();
            tbxClicDroit = new TextBox();
            tbxPositionX = new TextBox();
            tbxPositionY = new TextBox();
            lblClavier = new Label();
            lblClicGauche = new Label();
            lblClicDroit = new Label();
            lblPositionX = new Label();
            lblPositionY = new Label();
            SuspendLayout();
            // 
            // pnlSouris
            // 
            pnlSouris.BackColor = SystemColors.ControlLight;
            pnlSouris.BorderStyle = BorderStyle.Fixed3D;
            pnlSouris.Location = new Point(316, 71);
            pnlSouris.Name = "pnlSouris";
            pnlSouris.Size = new Size(442, 367);
            pnlSouris.TabIndex = 0;
            pnlSouris.MouseDown += pnlSouris_MouseDown;
            pnlSouris.MouseMove += pnlSouris_MouseMove;
            // 
            // lsbClavier
            // 
            lsbClavier.FormattingEnabled = true;
            lsbClavier.Location = new Point(12, 33);
            lsbClavier.Name = "lsbClavier";
            lsbClavier.Size = new Size(276, 344);
            lsbClavier.TabIndex = 1;
            lsbClavier.KeyPress += EcranClavierSouris_KeyPress;
            // 
            // butRAZ
            // 
            butRAZ.Location = new Point(12, 392);
            butRAZ.Name = "butRAZ";
            butRAZ.Size = new Size(276, 46);
            butRAZ.TabIndex = 2;
            butRAZ.Text = "Remise à zéro";
            butRAZ.UseVisualStyleBackColor = true;
            butRAZ.Click += butRAZ_Click;
            // 
            // tbxClicGauche
            // 
            tbxClicGauche.Location = new Point(316, 33);
            tbxClicGauche.Name = "tbxClicGauche";
            tbxClicGauche.Size = new Size(106, 27);
            tbxClicGauche.TabIndex = 4;
            // 
            // tbxClicDroit
            // 
            tbxClicDroit.Location = new Point(428, 33);
            tbxClicDroit.Name = "tbxClicDroit";
            tbxClicDroit.Size = new Size(106, 27);
            tbxClicDroit.TabIndex = 5;
            // 
            // tbxPositionX
            // 
            tbxPositionX.Location = new Point(540, 33);
            tbxPositionX.Name = "tbxPositionX";
            tbxPositionX.Size = new Size(106, 27);
            tbxPositionX.TabIndex = 6;
            // 
            // tbxPositionY
            // 
            tbxPositionY.Location = new Point(652, 33);
            tbxPositionY.Name = "tbxPositionY";
            tbxPositionY.Size = new Size(106, 27);
            tbxPositionY.TabIndex = 7;
            // 
            // lblClavier
            // 
            lblClavier.AutoSize = true;
            lblClavier.Location = new Point(12, 9);
            lblClavier.Name = "lblClavier";
            lblClavier.Size = new Size(136, 20);
            lblClavier.TabIndex = 8;
            lblClavier.Text = "Interception clavier";
            // 
            // lblClicGauche
            // 
            lblClicGauche.AutoSize = true;
            lblClicGauche.Location = new Point(316, 9);
            lblClicGauche.Name = "lblClicGauche";
            lblClicGauche.Size = new Size(85, 20);
            lblClicGauche.TabIndex = 9;
            lblClicGauche.Text = "Clic gauche";
            // 
            // lblClicDroit
            // 
            lblClicDroit.AutoSize = true;
            lblClicDroit.Location = new Point(428, 9);
            lblClicDroit.Name = "lblClicDroit";
            lblClicDroit.Size = new Size(69, 20);
            lblClicDroit.TabIndex = 10;
            lblClicDroit.Text = "Clic droit";
            // 
            // lblPositionX
            // 
            lblPositionX.AutoSize = true;
            lblPositionX.Location = new Point(540, 9);
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Size = new Size(74, 20);
            lblPositionX.TabIndex = 11;
            lblPositionX.Text = "Position X";
            // 
            // lblPositionY
            // 
            lblPositionY.AutoSize = true;
            lblPositionY.Location = new Point(652, 9);
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Size = new Size(73, 20);
            lblPositionY.TabIndex = 12;
            lblPositionY.Text = "Position Y";
            // 
            // EcranClavierSouris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 450);
            Controls.Add(lblPositionY);
            Controls.Add(lblPositionX);
            Controls.Add(lblClicDroit);
            Controls.Add(lblClicGauche);
            Controls.Add(lblClavier);
            Controls.Add(tbxPositionY);
            Controls.Add(tbxPositionX);
            Controls.Add(tbxClicDroit);
            Controls.Add(tbxClicGauche);
            Controls.Add(butRAZ);
            Controls.Add(lsbClavier);
            Controls.Add(pnlSouris);
            Name = "EcranClavierSouris";
            Text = "EcranClavierSouris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSouris;
        private ListBox lsbClavier;
        private Button butRAZ;
        private TextBox tbxClicGauche;
        private TextBox tbxClicDroit;
        private TextBox tbxPositionX;
        private TextBox tbxPositionY;
        private Label lblClavier;
        private Label lblClicGauche;
        private Label lblClicDroit;
        private Label lblPositionX;
        private Label lblPositionY;
    }
}