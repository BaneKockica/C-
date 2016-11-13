using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class GlavnaAdmin : Form
    {
        public GlavnaAdmin()
        {
            InitializeComponent();
        }

        private void unosProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosNovogProizvoda().ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Uspesno ste se odjavili!");
            new Logovanje().ShowDialog();

        }

        private void izmenaIPretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaProizvoda().ShowDialog();
        }

        private void unosNovogKonobaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Unos_novog_konobara().ShowDialog();
        }

        private void izmenaIBrisanjeKonobaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaKonobara().ShowDialog();
        }

        private void GlavnaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
