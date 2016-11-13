using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        Server s;
        public Form1()
        {
            s = new Server();
            InitializeComponent();
            if (s.pokreniServer()) this.Text = "Server pokrenut!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            t.Tick += new EventHandler(osvezi);
            t.Interval = 3000;
            t.Start();
        }

        private void osvezi(object sender, EventArgs e)
        {
            Nova n = new Nova();
            textBox1.Text =n.vrati().ToString();
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
