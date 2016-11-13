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
    public partial class PretragaProizvoda : Form
    {
        KontrolerKI.KontrolerKI kki;
        public PretragaProizvoda()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
            kki.PrikaziProizvode(txtKriterijum, dgvPrikazProizvoda);
        }

        private void txtKriterijum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kki.PrikaziProizvode(txtKriterijum, dgvPrikazProizvoda);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
           if(kki.obrisiProizvod(dgvPrikazProizvoda))
            {
                kki.PrikaziProizvode(txtKriterijum, dgvPrikazProizvoda);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (kki.izaberiProizvod(dgvPrikazProizvoda)) new IzmeniProizvod().ShowDialog();
            this.Show();
        }
    }
}
