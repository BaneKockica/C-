using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
   public class Administrator:OpstiDomenskiObjekat
    {
        int administratorID;

        public int AdministratorID
        {
            get { return administratorID; }
            set { administratorID = value; }
        }

        string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [Browsable(false)]
        public string tabela
        {
            get { return "Administrator"; }
        }

        [Browsable(false)]
        public string kljuc
        {
            get { return "AdministratorID"; }
        }

        [Browsable(false)]
        public string uslovJedan
        {
            get { return "AdministratorID=" + administratorID; }
        }

        [Browsable(false)]
        public string uslovVise
        {
            get { return "Username='" +username+ "' AND Password='" +password+ "'"; }
        }

        [Browsable(false)]
        public string azuriranje
        {
            get { return null; }
        }

        [Browsable(false)]
        public string upisivanje
        {
            get { return null; }
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }
        public OpstiDomenskiObjekat napuni(System.Data.DataRow red)
        {
            Administrator a = new Administrator();
            a.AdministratorID = Convert.ToInt32(red[0]);
            a.Ime = red[1].ToString();
            a.Prezime = red[2].ToString();
            a.Username = red[3].ToString();
            a.Password = red[4].ToString();

            return a;
        }
    }
}
