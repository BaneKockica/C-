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
    public partial class StorniranjeRacuna : Form
    {
        KontrolerKI.KontrolerKI kki;
        public StorniranjeRacuna()
        {
            kki = new KontrolerKI.KontrolerKI();
            InitializeComponent();
        }

        private void StorniranjeRacuna_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToShortDateString();
            kki.PrikaziRacune(textBox1, dataGridView1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kki.PrikaziRacune(textBox1, dataGridView1);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kki.obrisiRacun(textBox1,dataGridView1))
            {
                kki.PrikaziRacune(textBox1, dataGridView1);
                dataGridView1.Refresh();
            }

        }
    }
}
