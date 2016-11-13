using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class StavkaRacuna:OpstiDomenskiObjekat
    {
        Proizvod proizvod;
        double vrednost;
        int kolicina;
        int redniBroj;
        int stavkaRacunaID;
        [Browsable(false)]
        public int StavkaRacunaID
        {
            get
            {
                return stavkaRacunaID;
            }

            set
            {
                stavkaRacunaID = value;
            }
        }
        

        public int RedniBroj
        {
            get
            {
                return redniBroj;
            }

            set
            {
                redniBroj = value;
            }
        }

        public Proizvod Proizvod
        {
            get
            {
                return proizvod;
            }

            set
            {
                proizvod = value;
            }
        }

        public int Kolicina
        {
            get
            {
                return kolicina;
            }

            set
            {
                kolicina = value;
            }
        }

        public double Vrednost
        {
            get
            {
                return vrednost;
            }

            set
            {
                vrednost = value;
            }
        }

      

        [Browsable(false)]
        public string tabela
        {
            get { return "StavkaRacuna"; }
        }

        [Browsable(false)]
        public string kljuc
        {
            get { return "StavkaRacunaID"; }
        }

        [Browsable(false)]
        public string uslovJedan
        {
            get { return "StavkaRacunaID = " + stavkaRacunaID + " and RedniBroj = " + redniBroj; }
        }

        [Browsable(false)]
        public string uslovVise
        {
            get { return "StavkaRacunaID="+stavkaRacunaID+""; }
        }

        [Browsable(false)]
        public string azuriranje
        {
            get { return null; }
        }

        [Browsable(false)]
        public string upisivanje
        {
            get { return "(" + stavkaRacunaID + "," + redniBroj + ", " + kolicina + ", " + vrednost + ", "+proizvod.SifraProizvoda+")"; }
        }

        public OpstiDomenskiObjekat napuni(System.Data.DataRow red)
        {
            StavkaRacuna sr = new StavkaRacuna();
            sr.StavkaRacunaID = Convert.ToInt32(red[0]);
            sr.RedniBroj = Convert.ToInt32(red[1]);
            sr.Kolicina = Convert.ToInt32(red[2]);
            sr.Vrednost = Convert.ToDouble(red[3]);
            sr.Proizvod = new Proizvod();
            sr.Proizvod.SifraProizvoda = Convert.ToInt32(red[4]);
          

            return sr;
        }
    }
}
