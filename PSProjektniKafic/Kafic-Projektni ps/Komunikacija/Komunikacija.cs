using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Komunikacija
{
    public class Komunikacija
    {

        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 10000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Administrator LogovanjeAdmina(Administrator a)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.LogovanjeAdmina;
            transfer.TransferObjekat = a;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Administrator;

        }

        public Konobar LogovanjeKonobara(Konobar k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.LogovanjeKonobara;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Konobar;

        }

        public Proizvod kreirajProizvod()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajProizvod;
            transfer.TransferObjekat = new Proizvod();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Proizvod;
        }
        public Konobar kreirajKonobara()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajKonobara;
            transfer.TransferObjekat = new Konobar();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Konobar;
        }
        public Racun kreirajRacun()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajRacun;
            transfer.TransferObjekat = new Racun();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Racun;
        }
        public object sacuvajProizvod(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajProizvod;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object sacuvajKonobara(Konobar k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajKonobara;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        public object sacuvajRacun(Racun racun)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.SacuvajRacun;
            transfer.TransferObjekat = racun;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Proizvod> pronadjiSveProizvode(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiSveProizvode;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Proizvod>;
        }

        public List<Konobar> pronadjiSveKonobare(Konobar k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiSveKonobare;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Konobar>;
        }
        public List<Proizvod> pronadjiProizvodeZaKriterijum(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiProizvodeZaKriterijum;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Proizvod>;
        }

        public List<Racun> pronadjiRacuneZaKriterijum(Racun r)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PronadjiRacunZaKriterijum;
            transfer.TransferObjekat = r;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Racun>;
        }

        public int obrisiRacun(Racun racun)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiRacin;
            transfer.TransferObjekat = racun;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return (int)transfer.Rezultat;
        }

        public Object obrisiProizvod(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiProizvod;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object obrisiKonobara(Konobar k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiKonobara;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object izmeniProizvod(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniProizvod;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object izmeniKonobara(Konobar k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.IzmeniKonobara;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

      

    }
}
