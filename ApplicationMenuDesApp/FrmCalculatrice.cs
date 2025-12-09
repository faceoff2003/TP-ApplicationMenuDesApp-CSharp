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
    public partial class FrmCalculatrice : Form
    {
        double nombre1;
        double nombre2;
        double resultat;

        public FrmCalculatrice()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            nombre1 = Convert.ToDouble(txtVal1.Text);
            nombre2 = Convert.ToDouble(txtVal2.Text);
            resultat = nombre1 + nombre2;

            lblAffichage.Text = resultat.ToString();
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            nombre1 = Convert.ToDouble(txtVal1.Text);
            nombre2 = Convert.ToDouble(txtVal2.Text);
            resultat = nombre1 - nombre2;

            lblAffichage.Text = resultat.ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            nombre1 = Convert.ToDouble(txtVal1.Text);
            nombre2 = Convert.ToDouble(txtVal2.Text);
            resultat = nombre1 * nombre2;

            lblAffichage.Text = resultat.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            nombre1 = Convert.ToDouble(txtVal1.Text);
            nombre2 = Convert.ToDouble(txtVal2.Text);
            resultat = nombre1 / nombre2;

            lblAffichage.Text = resultat.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVal1.Text = "";
            txtVal2.Text = "";
            lblAffichage.Text = "";
        }
        //public void solution(string a, string b,string resultat)
        //{
        //    a=txtVal1.Text;
        //    b=txtVal2.Text;

        //    if (a != null || b != null)
        //    {
        //        MessageBox.Show("veuillez replir les 2 champs svp").ToString();
        //    }
        //    else
        //    { 
        //        double n;
        //        if ((double.TryParse(a, out n) == false) || (double.TryParse(b, out n)))
        //        {
        //            MessageBox.Show("Veuillez remplir les champs avec des nombre Seulement").ToString();

        //        }
        //        else
        //        { lblAffichage.Text = resultat; }
            
            
        //    }
        
        
        //}
    }
}
