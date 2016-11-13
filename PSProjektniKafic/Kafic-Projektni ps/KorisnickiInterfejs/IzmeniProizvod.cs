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
    public partial class IzmeniProizvod : Form
    {
        KontrolerKI.KontrolerKI kki;
        public IzmeniProizvod()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
        }

        private void IzmeniProizvod_Load(object sender, EventArgs e)
        {
            kki.popuniPolja(txtNaziv, txtSastojci, txtPriprema, txtCena);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kki.izmeniProizvod(txtNaziv, txtSastojci, txtPriprema, txtCena))
            {
                this.Close();
            }   
        }
    }
}
