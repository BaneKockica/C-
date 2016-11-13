using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Racun:OpstiDomenskiObjekat
    {
        int brojRacuna;
        DateTime datumIzdavanja;
        double ukupnaVrednost;
        Konobar konobar;

        public int BrojRacuna
        {
            get
            {
                return brojRacuna;
            }

            set
            {
                brojRacuna = value;
            }
        }

        public DateTime DatumIzdavanja
        {
            get
            {
                return datumIzdavanja;
            }

            set
            {
                datumIzdavanja = value;
            }
        }

        public double UkupnaVrednost
        {
            get
            {
                return ukupnaVrednost;
            }

            set
            {
                ukupnaVrednost = value;
            }
        }
        [Browsable(false)]
        public Konobar Konobar
        {
            get
            {
                return konobar;
            }

            set
            {
                konobar = value;
            }
        }

        private string konobarIspis;

        BindingList<StavkaRacuna> listaStavki;

        public Racun()
        {
            ListaStavki = new BindingList<StavkaRacuna>();
        }

        [Browsable(false)]
        public string tabela
        {
            get { return "Racun"; }
        }

        [Browsable(false)]
        public string kljuc
        {
            get { return "BrojRacuna"; }
        }

        [Browsable(false)]
        public string uslovJedan
        {
            get { return "BrojRacuna=" + brojRacuna; }
        }

        [Browsable(false)]
        public string uslovVise
        {
            get { return "DatumIzdavanja='" + datumIzdavanja + "'"; }
        }

        [Browsable(false)]
        public string azuriranje
        {
            get { return null; }
        }

        [Browsable(false)]
        public string upisivanje
        {
            get { return "(" + brojRacuna + ",'" + datumIzdavanja + "', " + ukupnaVrednost + ", " + konobar.KonobarID + ")"; }
        }

        public BindingList<StavkaRacuna> ListaStavki
        {
            get
            {
                return listaStavki;
            }

            set
            {
                listaStavki = value;
            }
        }
        [DisplayName("Konobaar")]
        public string KonobarIspis
        {
            get
            {
                return konobar.Ime+" "+konobar.Prezime;
            }

            set
            {
                konobarIspis = value;
            }
        }

        public OpstiDomenskiObjekat napuni(System.Data.DataRow red)
        {
            Racun r = new Racun();
            r.BrojRacuna = Convert.ToInt32(red[0]);
            r.DatumIzdavanja = Convert.ToDateTime(red[1]);
            r.UkupnaVrednost = Convert.ToDouble(red[2]);
            r.Konobar = new Konobar();
            r.Konobar.KonobarID = Convert.ToInt32(red[3]);

            return r;
        }


    }
}
