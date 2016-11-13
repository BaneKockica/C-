using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domen
{
    public enum Operacije { Kraj = 1,
        LogovanjeAdmina = 2,
        LogovanjeKonobara = 3,
        KreirajProizvod = 4,
        SacuvajProizvod = 5,
        PronadjiSveProizvode = 6,
        PronadjiProizvodeZaKriterijum = 7,
        ObrisiProizvod = 8,
        IzmeniProizvod = 9,
        KreirajKonobara = 10,
        SacuvajKonobara = 11,
        PronadjiSveKonobare = 12,
        ObrisiKonobara = 13,
        IzmeniKonobara = 14,
        KreirajRacun = 15,
        SacuvajRacun = 16,
        PronadjiRacunZaKriterijum = 17,
        ObrisiRacin = 18
    }

    [Serializable]
    public class TransferKlasa
    {

        Operacije operacija;

        public Operacije Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }
        Object transferObjekat;

        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }
        Object rezultat;

        public Object Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }
    }
}
