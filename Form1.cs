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
            if (x==0)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        
    }
}
