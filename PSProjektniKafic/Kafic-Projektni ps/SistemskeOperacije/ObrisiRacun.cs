using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
   public class ObrisiRacun:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {

            Racun r = odo as Racun;
            StavkaRacuna sr=new StavkaRacuna();
            sr.StavkaRacunaID = r.BrojRacuna;
            List<StavkaRacuna> lista = Sesija.Broker.dajSesiju().dajSveZaUslovVise(sr).OfType<StavkaRacuna>().ToList<StavkaRacuna>();
            foreach (StavkaRacuna s in lista)
            {
                Sesija.Broker.dajSesiju().obrisi(s);
            }
            return Sesija.Broker.dajSesiju().obrisi(r);
        }
    }
}
