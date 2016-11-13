using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Komunikacija;
using System.Windows.Forms;
namespace KontrolerKI
{
    public class KontrolerKI
    {
        public static Komunikacija.Komunikacija kom;
        public static Administrator a;
        public static Konobar k;
        public static Proizvod proizvod;
        public static Racun racun;
        public static StavkaRacuna stavkaRacuna;
        public static int brojac=0;
        public static bool poveziSeNaServer()
        {
            kom = new Komunikacija.Komunikacija();
            return kom.poveziSeNaServer();
        }

        public int LogovanjeAdmina(TextBox txtUsername, TextBox txtPassword)
        {
            brojac++;
            Administrator a = new Administrator();
            a.Username = txtUsername.Text;
            a.Password = txtPassword.Text;

            a = kom.LogovanjeAdmina(a);
            if (a == null)
            {
                return 0;
            }
            else
            {
                KontrolerKI.a = a;
                return 1;

            }

        }
        public int LogovanjeKonobara(TextBox txtUsername, TextBox txtPassword)
        {
            brojac++;
            Konobar k = new Konobar();
            k.Username = txtUsername.Text;
            k.Password = txtPassword.Text;

            k = kom.LogovanjeKonobara(k);
            if (k == null)
            {
                return 0;
            }
            else
            {
                KontrolerKI.k = k;
                return 1;
            }

        }

        public void kreirajProizvod(TextBox txtSifra, GroupBox groupBox1)
        {
            txtSifra.Clear();
            brojac++;
            groupBox1.Visible = false;
            proizvod = kom.kreirajProizvod();
            if (proizvod == null)
            {
                MessageBox.Show("Sistem ne moze da kreira nov proizvod!");
            }

            else
            {
                brojac++;
                MessageBox.Show("Sistem je kreirao nov proizvod!");
                txtSifra.Text = proizvod.SifraProizvoda.ToString();

                groupBox1.Visible = true;

            }
        }

        public void kreirajKonobara(TextBox txtSifra, GroupBox groupBox1)
        {
            txtSifra.Clear();
            brojac++;
            groupBox1.Visible = false;
            k = kom.kreirajKonobara();
            if (k == null)
            {
                MessageBox.Show("Sistem ne moze da kreira novog konobara!");
                


            }

            else
            {
                MessageBox.Show("Sistem je kreirao novog konobara!");
                txtSifra.Text = k.KonobarID.ToString();
                groupBox1.Visible = true;

            }
        }

        public void kreirajRacun(TextBox txtbrojRacuna, TextBox txtDatumIzdavanja, TextBox txtUkupnaVrednost ,Button btnSacuvaj, GroupBox groupBox1, DataGridView dgv)
        {
            txtbrojRacuna.Clear();
            brojac++;
            groupBox1.Visible = false;
            btnSacuvaj.Visible = false;
            racun = kom.kreirajRacun();
            if (racun == null)
            {
                MessageBox.Show("Sistem ne moze da kreira nov račun!");

             }

            else
            {
                MessageBox.Show("Sistem je kreirao nov račun!");
                txtbrojRacuna.Text = racun.BrojRacuna.ToString();
                txtDatumIzdavanja.Text = DateTime.Now.ToShortDateString();
                txtUkupnaVrednost.Text = racun.UkupnaVrednost.ToString();
                dgv.DataSource = racun.ListaStavki;
                groupBox1.Visible = true;
                btnSacuvaj.Visible = true;

            }
        }

        public bool sacuvajProizvod(TextBox txtNaziv, TextBox txtSastojci, TextBox txtPriprema, TextBox txtCena)
        {
            brojac++;
            proizvod.NazivProizvoda = txtNaziv.Text;
            proizvod.Sastojci = txtSastojci.Text;
            proizvod.Priprema = txtPriprema.Text;
            proizvod.Administrator = KontrolerKI.a;
            try
            {
                proizvod.Cena = Convert.ToDouble(txtCena.Text);
            }
            catch (Exception)
            {
                brojac++;
                MessageBox.Show("Morate uneti broj!");
                txtCena.Focus();
                return false;
            }

            Object o = kom.sacuvajProizvod(proizvod);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti proizvod!");
                return false;
            }

            else
            {
                MessageBox.Show("Sistem je uspesno zapamtio proizvod!");
                return true;
            }
        }

        public bool sacuvajKonobara(TextBox txtJmbg, TextBox txtIme, TextBox txtPrezime, TextBox txtUsername, TextBox txtPassword)
        {
            brojac++;
            if (LogovanjeKonobara(txtUsername, txtPassword)==1)
            {
                MessageBox.Show("Vec postoji konobar sa tom lozinkom i korisnickim imenom!");
                txtPassword.Clear();
                txtPassword.Focus();
                return false;
            }
            else
            {
                k.Ime = txtIme.Text;
                k.Prezime = txtPrezime.Text;
                k.Username = txtUsername.Text;
                k.Password = txtPassword.Text;
                try
                {
                    k.Jmbg = Convert.ToInt32(txtJmbg.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Morate uneti broj!");
                    txtJmbg.Clear();
                    txtJmbg.Focus();
                    return false;
                }

                Object o = kom.sacuvajKonobara(k);
                if (o == null)
                {
                    MessageBox.Show("Sistem ne moze da zapamti konobara!");
                    return false;
                }

                else
                {
                    MessageBox.Show("Sistem je uspesno zapamtio konobara!");
                    return true;
                }
            }
          
        }


        public void PrikaziProizvode(TextBox txtNaziv, DataGridView dgvPrikazProizvoda)
        {
            brojac++;
            proizvod = new Proizvod();
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {

                List<Proizvod> lista = kom.pronadjiSveProizvode(proizvod);
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("Nema podataka u bazi!");
                }
                else

                    dgvPrikazProizvoda.DataSource = lista;
            }
            else
            {
                proizvod.NazivProizvoda = txtNaziv.Text;
                List<Proizvod> lista = kom.pronadjiProizvodeZaKriterijum(proizvod);
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("Nema proizvoda za zadati kriterijum!");
                    txtNaziv.Clear();
                }
                else
                {
                    MessageBox.Show("Sistem je našao proizvod po zadatkoj vrednosti!");
                    dgvPrikazProizvoda.DataSource = lista;

                }
                   

            }
        }

        public void PrikaziRacune(TextBox txtDatum, DataGridView dgvPrikazRacuna)
        {
            brojac++;
            racun = new Racun();
            if (string.IsNullOrWhiteSpace(txtDatum.Text))
            {

                List<Racun> lista = kom.pronadjiRacuneZaKriterijum(racun);
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("Nema podataka u bazi!");
                }
                else
                {
                    foreach (Racun item in lista)
                    {
                        Konobar k = new Konobar();
                        foreach (Konobar kon in kom.pronadjiSveKonobare(k))
                        {
                            if (item.Konobar.KonobarID == kon.KonobarID)
                            {
                                item.Konobar = kon;
                            }
                        }
                    }
                    dgvPrikazRacuna.DataSource = lista;
                }
            }
            else
            {
                try
                {
                    racun.DatumIzdavanja = Convert.ToDateTime(txtDatum.Text);

                }
                catch (Exception)
                {

                    MessageBox.Show("Unesi datum");
                    return;
                }
                List<Racun> lista = kom.pronadjiRacuneZaKriterijum(racun);
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("Nema racuna za zadati kriterijum!");
                    dgvPrikazRacuna.DataSource = lista;
                }
                else
                {
                    foreach (Racun item in lista)
                    {
                        Konobar k = new Konobar();
                        foreach (Konobar kon in kom.pronadjiSveKonobare(k))
                        {
                            if (item.Konobar.KonobarID == kon.KonobarID)
                            {
                                item.Konobar = kon;
                            }
                        }
                    }
                    MessageBox.Show("Sistem je našao račune za zadati kriterijum!");
                    dgvPrikazRacuna.DataSource = lista;

                }

            }
        }

       
        public bool obrisiRacun(TextBox txtDatum ,DataGridView dgvPrikazRacuna)
        {
            brojac++;
            try
            {
                racun = dgvPrikazRacuna.CurrentRow.DataBoundItem as Racun;
            }

            catch (Exception)
            {

                MessageBox.Show("Selektujte racun kog želite da obrišete");
            }

            int o = kom.obrisiRacun(racun);
            if (o == 0)
            {
                MessageBox.Show("Sistem ne moze da obrise račun!");
                PrikaziRacune(txtDatum, dgvPrikazRacuna);
                return false;
            }

            else
            {
                MessageBox.Show("Sistem je obrisao racun!");
                PrikaziRacune(txtDatum, dgvPrikazRacuna);
                return true;
            }
        }

        public void PrikaziKonobare(DataGridView dgvPrikazKonobara)
        {
                k = new Konobar();
            brojac++;

            List<Konobar> lista = kom.pronadjiSveKonobare(k);
              
                    dgvPrikazKonobara.DataSource = lista;

                
            
            
        }
        public void PrikaziRacune(DataGridView dgvPrikazRacuna)
        {
           Racun r= new Racun();


            List<Racun> lista = kom.pronadjiRacuneZaKriterijum(r);

            dgvPrikazRacuna.DataSource = lista;

            brojac++;



        }




        public bool obrisiProizvod(DataGridView dgvPrikazProizvoda)
        {
            brojac++;
            try
            {
                proizvod = dgvPrikazProizvoda.CurrentRow.DataBoundItem as Proizvod;
            }

            catch (Exception)
            {

                MessageBox.Show("Selektujte proizvod kog želite da obrišete");
            }

            Object o = kom.obrisiProizvod(proizvod);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da obrise proizvod!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao proizvod!");
                return true;
            }
        }

        public bool obrisiKonobara(DataGridView dgvPrikazKononabara)
        {
            brojac++;
            try
            {
                k = dgvPrikazKononabara.CurrentRow.DataBoundItem as Konobar;
            }

            catch (Exception)
            {

                MessageBox.Show("Selektujte konobara kog želite da obrišete");
            }

            Object o = kom.obrisiKonobara(k);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da obrise konobara!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao konobara!");
                return true;
            }
        }

        public bool izaberiProizvod(DataGridView dgvPrikazProizvod)
        {
            try
            {
                proizvod = dgvPrikazProizvod.CurrentRow.DataBoundItem as Proizvod;
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali proizvod!");
                return false;
            }
        }
       
        public bool izaberiKonobara(DataGridView dgvPrikazKonobara)
        {
            try
            {
                k = dgvPrikazKonobara.CurrentRow.DataBoundItem as Konobar;
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali konobara!");
                return false;
            }
        }
        public void popuniPolja(TextBox txtNaziv, TextBox txtSastojci, TextBox txtPriprema, TextBox txtCena)
        {
            txtNaziv.Text = proizvod.NazivProizvoda;
            txtSastojci.Text = proizvod.Sastojci;
            txtPriprema.Text = proizvod.Priprema;
            txtCena.Text = proizvod.Cena.ToString();
           
        }

        public void popuniComboBoxProizvodi(ComboBox cbProizvodi)
        {
            Proizvod p = new Proizvod();
            cbProizvodi.DataSource = kom.pronadjiSveProizvode(p);

        }

        public void dodajStavku(ComboBox cbProizvodi, TextBox txtKolicina, TextBox txtukupnaVrednost)
        {
            StavkaRacuna sr = new StavkaRacuna();
            sr.StavkaRacunaID = racun.BrojRacuna;
            sr.RedniBroj = racun.ListaStavki.Count + 1;
            sr.Proizvod = cbProizvodi.SelectedItem as Proizvod;

            
            try
            {
                sr.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste ispravno uneli kolicinu!");
                txtKolicina.Clear();
                txtKolicina.Focus();
                return;
            }
            try
            {
                sr.Vrednost = sr.Kolicina * sr.Proizvod.Cena;

            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali proizvod");
                return;
            }
            racun.UkupnaVrednost += sr.Vrednost;
            txtukupnaVrednost.Text = racun.UkupnaVrednost.ToString();
            racun.ListaStavki.Add(sr);
            txtKolicina.Clear();
            cbProizvodi.Text = "";
        }


        public void obrisiStavku(DataGridView dgv, TextBox txtUkupnaVrednost)
        {
            try
            {
                StavkaRacuna sr = dgv.CurrentRow.DataBoundItem as StavkaRacuna;
                racun.ListaStavki.Remove(sr);
                racun.UkupnaVrednost -= sr.Vrednost;
                txtUkupnaVrednost.Text = racun.UkupnaVrednost.ToString();
                int i = 1;

                foreach (StavkaRacuna s in racun.ListaStavki)
                {
                    s.RedniBroj = i;
                    i++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste lepo odabrali stavku!");
            }
        }

        public void sacuvajRacun(TextBox txtBrojRacuna, TextBox txtDatum, TextBox txtUkupnaVrednost, GroupBox groupBox1, Button btnSacuvaj)
        {
            brojac++;
            racun.BrojRacuna = Convert.ToInt32(txtBrojRacuna.Text);
            racun.DatumIzdavanja = DateTime.Parse(txtDatum.Text);
            racun.UkupnaVrednost =Convert.ToDouble(txtUkupnaVrednost.Text);
            racun.Konobar = k;
            

            Object o = kom.sacuvajRacun(racun);

            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da sacuva racun!");
            }

            else
            {
                MessageBox.Show("Sistem je uspesno sacuvao racun!");

                txtBrojRacuna.Clear();
                txtDatum.Clear();
                txtUkupnaVrednost.Clear();
                groupBox1.Visible = false;
                btnSacuvaj.Visible = false;

            }

        }

        public void popuniPoljaKonobar(TextBox txtJmbg, TextBox txtIme, TextBox txtPrezime, TextBox txtUsername, TextBox txtPassword)
        {
            txtJmbg.Text = k.Jmbg.ToString();
            txtIme.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtUsername.Text = k.Username;
            txtPassword.Text = k.Password;


        }

        public bool izmeniProizvod(TextBox txtNaziv, TextBox txtSastojci, TextBox txtPriprema, TextBox txtCena)
        {
            brojac++;
            proizvod.NazivProizvoda = txtNaziv.Text;
            proizvod.Sastojci = txtSastojci.Text;
            proizvod.Priprema = txtPriprema.Text;
            try
            {
                proizvod.Cena = Convert.ToDouble(txtCena.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Unesite broj!");
                txtCena.Clear();
                txtCena.Focus();
                return false;
                
            }
            Object o = kom.izmeniProizvod(proizvod);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da izmeni proizvod!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je izmenio proizvod!");
                return true;
            }
        }
        public bool izmeniKonobara(TextBox txtJmbg, TextBox txtIme, TextBox txtPrezime, TextBox txtUsername, TextBox txtPassword)
        {
            brojac++;
            k.Jmbg = Convert.ToInt32( txtJmbg.Text);
            k.Ime = txtIme.Text;
            k.Prezime = txtPrezime.Text;
            k.Username = txtUsername.Text;
            k.Password = txtPassword.Text;

            object o = kom.izmeniKonobara(k);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da izmeni konobara!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je izmenio konobara!");
                return true;
            }
        }

    }
}
