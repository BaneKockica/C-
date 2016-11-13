using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class KreirajProizvod:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Proizvod p = odo as Proizvod;
            p.SifraProizvoda = Sesija.Broker.dajSesiju().dajID(p);
            return p;
        }
    }
}
