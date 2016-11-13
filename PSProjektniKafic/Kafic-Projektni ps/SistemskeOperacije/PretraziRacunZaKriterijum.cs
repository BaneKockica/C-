using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
   public class PretraziRacunZaKriterijum:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().dajSveZaUslovVise(odo).OfType<Racun>().ToList<Racun>();
        }

    }
}
