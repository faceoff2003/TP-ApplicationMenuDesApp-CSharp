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
    public partial class FrmConvertisseur : Form
    {


        public FrmConvertisseur()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtEuro.Text == "")
            {
                MessageBox.Show("Merci de remplir la zone Euro").ToString();
                txtEuro.Focus();

            }

            else
            {
                double n;
                if (double.TryParse(txtEuro.Text,out n) == false)
                {

                    MessageBox.Show("merci de remplir la zone EURO avec numéros SEULEMENT..").ToString();
                    txtEuro.Focus();
                    txtEuro.Select();

                }
                else
                {
                    double Euro = Convert.ToDouble(txtEuro.Text);
                    double DH = 10.65;

                    txtDirham.Text = (Euro * DH).ToString();

                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
