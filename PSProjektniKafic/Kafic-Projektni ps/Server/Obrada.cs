using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domen;
using Sesija;
using SistemskeOperacije;

namespace Server
{
   public class Obrada
    {

        BinaryFormatter formater;
        NetworkStream tok;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void obradiKlijenta()
        {
            int operacija = 0;
            while (operacija != (int)Operacije.Kraj)
            {
                TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                switch (transfer.Operacija)
                {
                    case Operacije.IzmeniProizvod:
                        IzmeniProizvod ip = new IzmeniProizvod();
                        transfer.Rezultat = ip.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.IzmeniKonobara:
                        IzmeniKonobara ik = new IzmeniKonobara();
                        transfer.Rezultat = ik.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.ObrisiProizvod:
                        ObrisiProizvod op = new ObrisiProizvod();
                        transfer.Rezultat = op.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.ObrisiKonobara:
                        ObrisiKonobara ok = new ObrisiKonobara();
                        transfer.Rezultat = ok.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PronadjiProizvodeZaKriterijum:
                        PronadjiProizvodeZaKriterijum ppzk = new PronadjiProizvodeZaKriterijum();
                        transfer.Rezultat = ppzk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PronadjiRacunZaKriterijum:
                        PretraziRacunZaKriterijum przk = new PretraziRacunZaKriterijum();
                        transfer.Rezultat = przk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.ObrisiRacin:
                        ObrisiRacun or = new ObrisiRacun();
                        transfer.Rezultat = or.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PronadjiSveProizvode:
                        PronadjiProizvodeSve pps = new PronadjiProizvodeSve();
                        transfer.Rezultat = pps.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.PronadjiSveKonobare:
                        PronadjiSveKonobare psk = new PronadjiSveKonobare();
                        transfer.Rezultat = psk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.SacuvajProizvod:
                        SacuvajProizvod sp = new SacuvajProizvod();
                        transfer.Rezultat = sp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.SacuvajKonobara:
                        SacuvajKonobara sk = new SacuvajKonobara();
                        transfer.Rezultat = sk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.KreirajProizvod:
                        KreirajProizvod kp = new KreirajProizvod();
                        transfer.Rezultat = kp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.KreirajRacun:
                        KreirajRacun kr = new KreirajRacun();
                        transfer.Rezultat = kr.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.SacuvajRacun:
                        SacuvajRacun sr = new SacuvajRacun();
                        transfer.Rezultat = sr.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.KreirajKonobara:
                        KreirajNovogKonobara knk = new KreirajNovogKonobara();
                        transfer.Rezultat = knk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.LogovanjeAdmina:
                        LogovanjeAdmin la = new LogovanjeAdmin();
                        transfer.Rezultat = la.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.LogovanjeKonobara:
                        LogovanjeKonobara lk = new LogovanjeKonobara();
                        transfer.Rezultat = lk.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                        formater.Serialize(tok, transfer);
                        break;
                    case Operacije.Kraj:
                        operacija = 1;
                        break;
                }
            }
        }   

    }
}
