namespace Fil_Rouge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int x = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Image temp = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 FenetreSecondaire = new Form2(this);
            //Form2 FenetreSecondaire = new Form2();
            this.Hide();
            FenetreSecondaire.ShowDialog();
            if (x == 0)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
            x = 0;

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void ClickNotImplemented(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Non implémenté");
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aProposForm aPropos = new aProposForm();
            //Musique.musique();
            aPropos Fenetre_àPropos = new aPropos();
            this.Hide();
            Fenetre_àPropos.ShowDialog();
            this.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranListe Fenetre_Liste = new EcranListe();
            this.Hide();
            Fenetre_Liste.ShowDialog();
            this.Show();
        }

        private void barreDeProgressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranProgression Fenetre_Progression = new EcranProgression();
            this.Hide();
            Fenetre_Progression.ShowDialog();
            this.Show();
        }

        private void editeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranEditeur Fenetre_Editeur = new EcranEditeur();
            this.Hide();
            Fenetre_Editeur.ShowDialog();
            this.Show();
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSpirographe FicSpirographe = new EcranSpirographe();
            this.Hide();
            FicSpirographe.ShowDialog();
            this.Show();
        }

        private void keyLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranClavierSouris FicClavierSouris = new EcranClavierSouris();
            this.Hide();
            FicClavierSouris.ShowDialog();
            this.Show();
        }

        private void russianExplorerexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranExplorateur FicExplorateur = new EcranExplorateur();
            this.Hide();
            FicExplorateur.ShowDialog();
            this.Show();
        }
    }
}
