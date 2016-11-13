using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
   public class KreirajRacun:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Racun r = odo as Racun;
            r.BrojRacuna = Sesija.Broker.dajSesiju().dajID(r);
            return r;
        }
    }
}
