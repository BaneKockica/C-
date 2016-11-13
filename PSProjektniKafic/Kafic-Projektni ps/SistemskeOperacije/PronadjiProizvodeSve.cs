﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
   public class PronadjiProizvodeSve:OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().dajSve(odo).OfType<Proizvod>().ToList<Proizvod>();
        }
    }
}
