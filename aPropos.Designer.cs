namespace Fil_Rouge
{
    partial class aPropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aPropos));
            panel1 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(34, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 307);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.Cursor = Cursors.No;
            textBox1.Location = new Point(249, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(455, 255);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Visual_Studio_Icon_2022_svg;
            pictureBox1.Location = new Point(27, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.FlatAppearance.BorderColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(239, 368);
            button1.Name = "button1";
            button1.Size = new Size(322, 70);
            button1.TabIndex = 1;
            button1.Text = "I agree to the terms and conditions";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // aPropos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "aPropos";
            Text = " YourSoul.exe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}