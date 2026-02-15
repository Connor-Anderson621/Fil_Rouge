namespace Fil_Rouge
{
    partial class EcranProgression
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
            pbPrincipal = new ProgressBar();
            pbSecondaire = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            bExecuter = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // pbPrincipal
            // 
            pbPrincipal.ForeColor = Color.Gold;
            pbPrincipal.Location = new Point(12, 69);
            pbPrincipal.Name = "pbPrincipal";
            pbPrincipal.Size = new Size(337, 43);
            pbPrincipal.TabIndex = 0;
            // 
            // pbSecondaire
            // 
            pbSecondaire.ForeColor = Color.Gold;
            pbSecondaire.Location = new Point(12, 178);
            pbSecondaire.Name = "pbSecondaire";
            pbSecondaire.Size = new Size(337, 43);
            pbSecondaire.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "Index Principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 3;
            label2.Text = "Index Secondaire";
            // 
            // bExecuter
            // 
            bExecuter.Location = new Point(12, 276);
            bExecuter.Name = "bExecuter";
            bExecuter.Size = new Size(170, 54);
            bExecuter.TabIndex = 4;
            bExecuter.Text = "Executer";
            bExecuter.UseVisualStyleBackColor = true;
            bExecuter.Click += bExecuter_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(188, 276);
            button2.Name = "button2";
            button2.Size = new Size(161, 54);
            button2.TabIndex = 5;
            button2.Text = "Quitter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EcranProgression
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(361, 360);
            Controls.Add(button2);
            Controls.Add(bExecuter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbSecondaire);
            Controls.Add(pbPrincipal);
            Name = "EcranProgression";
            Text = "EcranProgression";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar pbPrincipal;
        private ProgressBar pbSecondaire;
        private Label label1;
        private Label label2;
        private Button bExecuter;
        private Button button2;
    }
}