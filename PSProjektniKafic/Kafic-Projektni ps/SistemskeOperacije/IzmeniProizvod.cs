using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
   public class IzmeniProizvod:OpstaSO
    {
        public override object Izvrsi(Domen.OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().izmeni(odo);
        }
    }
}
