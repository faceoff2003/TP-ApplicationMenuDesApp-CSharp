using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationMenuDesApp
{
    public partial class ProCalculatrice : Form
    {
        public ProCalculatrice()
        {
            InitializeComponent();
  
        }

        double Contraire;
        string operation;

        public void regle(string valeur)
        {
            if (txtResultat.Text == "0")
            {
                txtResultat.Text = valeur;
            }

            else
            {
                txtResultat.Text = txtResultat.Text + valeur;
            }
        }
            public void signe(string op)
            {
            Contraire = Convert.ToDouble(txtResultat.Text);
            operation = op;
            txtResultat.Text = "";
            
        }

        private void ProCalculatrice_Load(object sender, EventArgs e)
        {
        }

        private void calculatriceSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width+93;
            txtResultat.Width = this.Width-93;
        }

        private void calculatriceProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = pnlStandard.Width + pnlPro.Width+110;
            txtResultat.Width = this.Width-107;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            regle("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            regle("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            regle("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            regle("4");
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            regle("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            regle("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            regle("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            regle("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            regle("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            regle("0");
        }

        private void btnVergule_Click(object sender, EventArgs e)
        {
            if (txtResultat.Text.Contains(",")==false)
            {
                txtResultat.Text = txtResultat.Text + ",";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultat.Text = "";
        }

        private void btnPlusSurMoin_Click(object sender, EventArgs e)
        {
            if (txtResultat.Text == "")
            {
                txtResultat.Text = "";
            }
            else
            Contraire =(Convert.ToDouble(txtResultat.Text)) * (-1);
            txtResultat.Text = Contraire.ToString();
        }

        private void btn1surCent_Click(object sender, EventArgs e)
        {
            Contraire = 1 / (Convert.ToDouble(txtResultat.Text));
            txtResultat.Text = Contraire.ToString();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            Contraire = (Convert.ToDouble(txtResultat.Text)) * (Convert.ToDouble(txtResultat.Text));
            txtResultat.Text = Contraire.ToString();
        }

        private void btn2RacineX_Click(object sender, EventArgs e)
        {
            Contraire = Math.Sqrt(Convert.ToDouble(txtResultat.Text));
            txtResultat.Text = Contraire.ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            signe("+");
            //Contraire = Convert.ToDouble(txtResultat.Text);
            //operation = "+";
            //txtResultat.Text = "";
        }

        private void btnEgale_Click(object sender, EventArgs e)
        {
            if (operation == "+")
            {
                Contraire = Contraire + Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = Contraire.ToString();
            }
            else if (operation == "-")
            {
                Contraire = Contraire - Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = Contraire.ToString();
            }

            else if (operation == "x")
            {
                Contraire = Contraire * Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = Contraire.ToString();
            }

            else if (operation == "/")
            {
                if ((txtResultat.Text == "0") || ( txtResultat.Text == ""))
                {
                    MessageBox.Show("Cette division est impossible");
                    //txtResultat.Text = ("La division par 0 est impossible");
                }
                else

                Contraire = Contraire / Convert.ToDouble(txtResultat.Text);
                txtResultat.Text = Contraire.ToString();
            }
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            signe("-");
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            signe("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            signe("/");
        }
    }
}
