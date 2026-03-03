namespace Fil_Rouge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            contrôlesToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            barreDeProgressionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            applicationsToolStripMenuItem = new ToolStripMenuItem();
            editeurToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(315, 365);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(277, 90);
            button1.TabIndex = 0;
            button1.Text = "Inverser images\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 234);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Bear;
            pictureBox2.Location = new Point(617, 234);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 231);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Location = new Point(315, 260);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(277, 89);
            button2.TabIndex = 3;
            button2.Text = "Fenêtre pop up\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(894, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contrôlesToolStripMenuItem, applicationsToolStripMenuItem, aideToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // contrôlesToolStripMenuItem
            // 
            contrôlesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem, barreDeProgressionToolStripMenuItem, toolStripMenuItem1, quitterToolStripMenuItem });
            contrôlesToolStripMenuItem.Name = "contrôlesToolStripMenuItem";
            contrôlesToolStripMenuItem.Size = new Size(224, 26);
            contrôlesToolStripMenuItem.Text = "Contrôles";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(230, 26);
            listeToolStripMenuItem.Text = "Liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // barreDeProgressionToolStripMenuItem
            // 
            barreDeProgressionToolStripMenuItem.Name = "barreDeProgressionToolStripMenuItem";
            barreDeProgressionToolStripMenuItem.Size = new Size(230, 26);
            barreDeProgressionToolStripMenuItem.Text = "Barre de progression";
            barreDeProgressionToolStripMenuItem.Click += barreDeProgressionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(227, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.ShortcutKeyDisplayString = "Alt + q";
            quitterToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Q;
            quitterToolStripMenuItem.Size = new Size(230, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // applicationsToolStripMenuItem
            // 
            applicationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editeurToolStripMenuItem });
            applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            applicationsToolStripMenuItem.Size = new Size(224, 26);
            applicationsToolStripMenuItem.Text = "Applications";
            // 
            // editeurToolStripMenuItem
            // 
            editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            editeurToolStripMenuItem.Size = new Size(224, 26);
            editeurToolStripMenuItem.Text = "Editeur";
            editeurToolStripMenuItem.Click += editeurToolStripMenuItem_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(224, 26);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(153, 26);
            aProposToolStripMenuItem.Text = "A propos";
            aProposToolStripMenuItem.Click += aProposToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.board;
            ClientSize = new Size(894, 530);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem contrôlesToolStripMenuItem;
        private ToolStripMenuItem applicationsToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem barreDeProgressionToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem editeurToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
    }
}
