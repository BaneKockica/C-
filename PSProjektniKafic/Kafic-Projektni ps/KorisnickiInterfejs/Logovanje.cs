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
    public partial class Logovanje : Form
    {
        KontrolerKI.KontrolerKI kki;
        public Logovanje()
        {
            InitializeComponent();
            
            kki = new KontrolerKI.KontrolerKI();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnUlogujSe_Click(object sender, EventArgs e)
            {
            if (kki.LogovanjeAdmina(txtUsername, txtPassword)==1)
            {
                GlavnaAdmin ga = new GlavnaAdmin();
                this.Hide();
                ga.ShowDialog();
                this.Close();
            }
            if (kki.LogovanjeKonobara(txtUsername, txtPassword)==1)
            {
                GlavnaKonobar gk = new GlavnaKonobar();
                this.Hide();
                gk.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Niste ste uspešno ulogovali!");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void Logovanje_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
