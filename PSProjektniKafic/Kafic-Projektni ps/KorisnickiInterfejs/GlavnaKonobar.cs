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
    public partial class GlavnaKonobar : Form
    {
        public GlavnaKonobar()
        {
            InitializeComponent();
        }

        private void novRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NovRacun().ShowDialog();
        }

        private void strorniranjeRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StorniranjeRacuna().ShowDialog();
        }

        private void meniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Meni().ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Uspešno ste se izlogovali!");
            new Logovanje().ShowDialog();
        }

        private void GlavnaKonobar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
