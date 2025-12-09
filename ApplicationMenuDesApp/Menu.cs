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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void convertisseurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            FrmConvertisseur frmConvertisseur = new FrmConvertisseur();
            frmConvertisseur.Show();
        }

        private void calculatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            FrmCalculatrice frmCalculatrice = new FrmCalculatrice();
            frmCalculatrice.Show();
        }

        private void proCalculatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.SendToBack();
            ProCalculatrice proCalculatrice = new ProCalculatrice();
            this.SendToBack();
            proCalculatrice.Show();

        }
    }
}
