using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Konobar:OpstiDomenskiObjekat
    {
        int konobarID;
        int jmbg;
        string ime;
        string prezime;
        string username;
        string password;
        public int KonobarID
        {
            get
            {
                return konobarID;
            }

            set
            {
                konobarID = value;
            }
        }
        public int Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                jmbg = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
     
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        [Browsable(false)]
        public string tabela
        {
            get { return "Konobar"; }
        }

        [Browsable(false)]
        public string kljuc
        {
            get { return "KonobarID"; }
        }

        [Browsable(false)]
        public string uslovJedan
        {
            get { return "KonobarID=" + konobarID; }
        }

        [Browsable(false)]
        public string uslovVise
        {
            get { return "Username='" + username + "' AND Password='" + password + "'"; }
        }

        [Browsable(false)]
        public string azuriranje
        {
            get { return "JMBG=" + jmbg + ", Ime='" + ime + "', Prezime= '" + prezime + "', Username= '" + username + "', Password= '" + password + "'"; }
        }

        [Browsable(false)]
        public string upisivanje
        {
            get { return  "("+konobarID+"," + jmbg + ",'" + ime + "', '" + prezime + "', '" + username + "', '"+password+"')";}
        }

        public OpstiDomenskiObjekat napuni(System.Data.DataRow red)
        {
            Konobar k = new Konobar();
            k.KonobarID = Convert.ToInt32(red[0]);
            k.Jmbg = Convert.ToInt32(red[1]);
            k.Ime = red[2].ToString();
            k.Prezime = red[3].ToString();
            k.Username = red[4].ToString();
            k.Password = red[5].ToString();
            return k;
        }


    }
}
