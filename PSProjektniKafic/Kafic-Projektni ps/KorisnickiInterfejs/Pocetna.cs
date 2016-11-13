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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            if (KontrolerKI.KontrolerKI.poveziSeNaServer()) this.Text = "Uspešno povezan!";
            new Logovanje().ShowDialog();
            this.Hide();
        }
    }
}
