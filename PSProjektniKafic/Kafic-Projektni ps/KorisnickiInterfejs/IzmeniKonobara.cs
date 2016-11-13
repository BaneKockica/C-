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
    public partial class IzmeniKonobara : Form
    {
        KontrolerKI.KontrolerKI kki;
        public IzmeniKonobara()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
        }

        private void IzmeniKonobara_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaKonobar(txtJmbg, txtIme, txtPrezime, txtUsername, txtPassword);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kki.izmeniKonobara(txtJmbg, txtIme, txtPrezime, txtUsername, txtPassword))
            {
                this.Close();
            }
        }
    }
}
