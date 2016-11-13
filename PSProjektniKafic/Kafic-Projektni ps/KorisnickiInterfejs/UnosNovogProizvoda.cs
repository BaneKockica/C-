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
    public partial class UnosNovogProizvoda : Form
    {
        KontrolerKI.KontrolerKI kki;
        public UnosNovogProizvoda()
        {
            InitializeComponent();
            kki = new KontrolerKI.KontrolerKI();
        }

        private void UnosNovogProizvoda_Load(object sender, EventArgs e)
        {

        }

        private void btnKreirajProizvod_Click(object sender, EventArgs e)
        {

            kki.kreirajProizvod(txtSifra, groupBox1);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.sacuvajProizvod(txtNaziv, txtSastojci, txtPriprema, txtCena)) this.Close();
        }
    }
}
