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
    public partial class NovRacun : Form
    {
        KontrolerKI.KontrolerKI kki;
        public NovRacun()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kki.kreirajRacun(txtBrojRacuna, txtDatumIzdavanja, txtUkupnaVrednost, btnSacuvajRacun, groupBox1, dataGridView1);
        }

        private void txtBrojRacuna_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            kki.dodajStavku(cbProizvodi, txtKolina,txtUkupnaVrednost);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NovRacun_Load(object sender, EventArgs e)
        {
            kki.popuniComboBoxProizvodi(cbProizvodi);
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            kki.obrisiStavku(dataGridView1, txtUkupnaVrednost);
        }

        private void btnSacuvajRacun_Click(object sender, EventArgs e)
        {
            kki.sacuvajRacun(txtBrojRacuna, txtDatumIzdavanja, txtUkupnaVrednost, groupBox1, btnSacuvajRacun);
        }
    }
}
