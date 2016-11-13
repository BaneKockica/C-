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
    public partial class PretragaKonobara : Form
    {
        KontrolerKI.KontrolerKI kki;
        public PretragaKonobara()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
        }

        private void PretragaKonobara_Load(object sender, EventArgs e)
        {
            kki.PrikaziKonobare(dgvPrikazKonobara);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kki.obrisiKonobara(dgvPrikazKonobara))
            {
                kki.PrikaziKonobare (dgvPrikazKonobara);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (kki.izaberiKonobara(dgvPrikazKonobara)) new IzmeniKonobara().ShowDialog();
            this.Show();
        }
    }
}
