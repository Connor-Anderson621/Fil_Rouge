namespace Fil_Rouge
{
    partial class EcranHistogramme
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
            bCréer = new Button();
            bDessiner = new Button();
            pDessin = new Panel();
            lbMonPoint = new ListBox();
            SuspendLayout();
            // 
            // bCréer
            // 
            bCréer.Location = new Point(575, 12);
            bCréer.Name = "bCréer";
            bCréer.Size = new Size(213, 48);
            bCréer.TabIndex = 0;
            bCréer.Text = "Créer";
            bCréer.UseVisualStyleBackColor = true;
            bCréer.Click += bCreer_Click;
            // 
            // bDessiner
            // 
            bDessiner.Location = new Point(12, 12);
            bDessiner.Name = "bDessiner";
            bDessiner.Size = new Size(213, 48);
            bDessiner.TabIndex = 1;
            bDessiner.Text = "Dessiner";
            bDessiner.UseVisualStyleBackColor = true;
            bDessiner.Click += bDessiner_Click;
            // 
            // pDessin
            // 
            pDessin.BackColor = SystemColors.Window;
            pDessin.Location = new Point(12, 66);
            pDessin.Name = "pDessin";
            pDessin.Size = new Size(552, 364);
            pDessin.TabIndex = 2;
            pDessin.Paint += pDessin_Paint;
            // 
            // lbMonPoint
            // 
            lbMonPoint.FormattingEnabled = true;
            lbMonPoint.Location = new Point(575, 66);
            lbMonPoint.Name = "lbMonPoint";
            lbMonPoint.Size = new Size(220, 364);
            lbMonPoint.TabIndex = 3;
            // 
            // EcranHistogramme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 442);
            Controls.Add(lbMonPoint);
            Controls.Add(pDessin);
            Controls.Add(bDessiner);
            Controls.Add(bCréer);
            Name = "EcranHistogramme";
            Text = "EcranHistogramme";
            ResumeLayout(false);
        }

        #endregion

        private Button bCréer;
        private Button bDessiner;
        private Panel pDessin;
        private ListBox lbMonPoint;
    }
}