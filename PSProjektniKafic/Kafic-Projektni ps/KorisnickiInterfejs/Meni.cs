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
    public partial class Meni : Form
    {
        KontrolerKI.KontrolerKI kki;
        public Meni()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kki.PrikaziProizvode(txtKriterijum, dgvPrikazProizvoda);
        }

        private void Meni_Load(object sender, EventArgs e)
        {
            kki.PrikaziProizvode(txtKriterijum, dgvPrikazProizvoda);
        }
    }
}
