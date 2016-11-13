using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
     public class KreirajNovogKonobara:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Konobar k = odo as Konobar;
            k.KonobarID = Sesija.Broker.dajSesiju().dajID(k);
            return k;
        }
    }
}
