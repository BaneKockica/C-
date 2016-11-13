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
    public partial class Unos_novog_konobara : Form
    {
        KontrolerKI.KontrolerKI kki;
        public Unos_novog_konobara()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.sacuvajKonobara(txtJmbg, txtIme, txtPrezime, txtUsername, txtPassword)) this.Close();
        }

        private void btnKreirajKonobara_Click(object sender, EventArgs e)
        {
            kki.kreirajKonobara(txtSifra, groupBox1);

        }

        private void Unos_novog_konobara_Load(object sender, EventArgs e)
        {

        }
    }
}
