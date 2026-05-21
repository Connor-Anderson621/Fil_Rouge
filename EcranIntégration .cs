using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fil_Rouge
{
        public partial class EcranIntégration : Form
        {
            public delegate double fctAIntegrer(double x);

            public EcranIntégration()
            {
                InitializeComponent();
            }

            private double MonPolynome(double x)
            {
                return (x * x) + 2;
            }

            private double MaTrigo(double x)
            {
                return Math.Sin(x);
            }

            private double IntegrationTrapeze(fctAIntegrer f, double xGauche, double xDroit, int nInterval)
            {
                double h = (xDroit - xGauche) / nInterval;
                double sommeAires = 0;

                for (int i = 0; i < nInterval; i++)
                {
                    double x1 = xGauche + (i * h);
                    double x2 = x1 + h;
                    sommeAires += (f(x1) + f(x2)) * h / 2.0;
                }
                return sommeAires;
            }

            private void bPointeurPolynome_Click(object sender, EventArgs e)
            {
                ActionPointeur("Méthode avec Pointeur\nPolynôme : x*x + 2", MonPolynome);
            }

            private void bPointeurTrigonometrique_Click(object sender, EventArgs e)
            {
                ActionPointeur("Méthode avec Pointeur\nTrigonométrique : sin(x)", MaTrigo);
            }

            private void ActionPointeur(string titre, fctAIntegrer f)
            {
                double gauche = Convert.ToDouble(tbGauche.Text);
                double droite = Convert.ToDouble(tbDroite.Text);
                int n = Convert.ToInt32(tbNbInt.Text);
                if (n < 1) n = 1;
                lbResultats.Items.Clear();
                lbResultats.Items.Add(titre);

                int m = 1;
                for (int i = 0; i < 5; i++)
                {
                    int intervallesActuels = n * m;
                    double res = IntegrationTrapeze(f, gauche, droite, intervallesActuels);
                    lbResultats.Items.Add("  Nb Int : " + intervallesActuels + " => " + res);
                    m *= 2;
                }
            }

            private void bPolynome_Click(object sender, EventArgs e)
            {
                double gauche = Convert.ToDouble(tbGauche.Text);
                double droite = Convert.ToDouble(tbDroite.Text);
                int n = Convert.ToInt32(tbNbInt.Text);
                if (n < 1) n = 1;

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode Traditionnelle");
                lbResultats.Items.Add("Polynôme : x*x + 2");

                int m = 1;
                for (int etape = 0; etape < 5; etape++)
                {
                    int intervallesActuels = n * m;
                    double h = (droite - gauche) / intervallesActuels;
                    double sommeAires = 0;
                    for (int i = 0; i < intervallesActuels; i++)
                    {
                        double x1 = gauche + (i * h);
                        double x2 = x1 + h;
                        sommeAires += (MonPolynome(x1) + MonPolynome(x2)) * h / 2.0;
                    }

                    lbResultats.Items.Add("  Nb Int : " + intervallesActuels + " => " + sommeAires);
                    m *= 2;
                }
            }

            private void bTrigonometrique_Click(object sender, EventArgs e)
            {
                double gauche = Convert.ToDouble(tbGauche.Text);
                double droite = Convert.ToDouble(tbDroite.Text);
                int n = Convert.ToInt32(tbNbInt.Text);
                if (n < 1) n = 1;

                lbResultats.Items.Clear();
                lbResultats.Items.Add("Méthode Traditionnelle");
                lbResultats.Items.Add("Trigonométrique : sin(x)");

                int m = 1;
                for (int etape = 0; etape < 5; etape++)
                {
                    int intervallesActuels = n * m;
                    double h = (droite - gauche) / intervallesActuels;
                    double sommeAires = 0;
                    for (int i = 0; i < intervallesActuels; i++)
                    {
                        double x1 = gauche + (i * h);
                        double x2 = x1 + h;
                        sommeAires += (MaTrigo(x1) + MaTrigo(x2)) * h / 2.0;
                    }

                    lbResultats.Items.Add("  Nb Int : " + intervallesActuels + " => " + sommeAires);
                    m *= 2;
                }
            }
        }
    }
