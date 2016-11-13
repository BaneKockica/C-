using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
   public class Nova:SistemskeOperacije.OpstaSO
    {

        public int vrati()
        {
          return SistemskeOperacije.OpstaSO.brojac;

        }
        public override object Izvrsi(Domen.OpstiDomenskiObjekat odo)
        {
            Object o = new Object();
            return o;
        }
    }
}
