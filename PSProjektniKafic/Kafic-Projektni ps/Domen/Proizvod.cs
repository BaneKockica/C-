using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Proizvod:OpstiDomenskiObjekat
    {
        int sifraProizvoda;
        string nazivProizvoda;
        string sastojci;
        string priprema;
        double cena;
        Administrator administrator;
        [Browsable(false)]
        public int SifraProizvoda
        {
            get
            {
                return sifraProizvoda;
            }

            set
            {
                sifraProizvoda = value;
            }
        }

        public string NazivProizvoda
        {
            get
            {
                return nazivProizvoda;
            }

            set
            {
                nazivProizvoda = value;
            }
        }

        public string Sastojci
        {
            get
            {
                return sastojci;
            }

            set
            {
                sastojci = value;
            }
        }
     

        public string Priprema
        {
            get
            {
                return priprema;
            }

            set
            {
                priprema = value;
            }
        }

        public double Cena
        {
            get
            {
                return cena;
            }

            set
            {
                cena = value;
            }
        }
    
        [Browsable(false)]
         public Administrator Administrator
        {
            get
            {
                return administrator;
            }

            set
            {
                administrator = value;
            }
        }

        [Browsable(false)]
        public string tabela
        {
            get { return "Proizvod"; }
        }

        [Browsable(false)]
        public string kljuc
        {
            get { return "SifraProizvoda"; }
        }

        [Browsable(false)]
        public string uslovJedan
        {
            get { return "SifraProizvoda=" + sifraProizvoda; }
        }

        [Browsable(false)]
        public string uslovVise
        {
            get { return "NazivProizvoda='"+nazivProizvoda+"'"; }
        }

        [Browsable(false)]
        public string azuriranje
        {
            get { return "NazivProizvoda='" + nazivProizvoda + "', Sastojci='" + sastojci + "', Priprema='" + priprema + "', Cena=" + cena + ""; }
        }

        [Browsable(false)]
        public string upisivanje
        {
            get { return "(" + sifraProizvoda + ",'" + nazivProizvoda + "','" + sastojci + "','" + priprema + "', '" + cena + "', " + administrator.AdministratorID+ ")"; }
        }

     

        public override string ToString()
        {
            return nazivProizvoda;
        }

        public OpstiDomenskiObjekat napuni(System.Data.DataRow red)
        {
            Proizvod p = new Proizvod();
            p.SifraProizvoda = Convert.ToInt32(red[0]);
            p.NazivProizvoda = red[1].ToString();
            p.Sastojci = red[2].ToString();
            p.Priprema = red[3].ToString();
            p.Cena = Convert.ToDouble(red[4]);
            p.Administrator = new Administrator();
            p.Administrator.AdministratorID = Convert.ToInt32(red[5]);

            return p;
        }
    }
}
