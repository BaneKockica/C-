using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
   public class SacuvajRacun:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {

            Racun r = odo as Racun;
            Sesija.Broker.dajSesiju().sacuvaj(odo);

            foreach (StavkaRacuna sr in r.ListaStavki)
            {
                sr.StavkaRacunaID = r.BrojRacuna;
                Sesija.Broker.dajSesiju().sacuvaj(sr);
            }

            return 1;


        }
    }
}
