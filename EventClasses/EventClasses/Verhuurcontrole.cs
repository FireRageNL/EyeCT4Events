using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Verhuurcontrole
    {
        private DBAdmin db = new DBAdmin();

        public void Huur(EventClasses.Object Materiaal, EventClasses.User User, DateTime BeginDatum, DateTime EindDatum , DateTime Nudatum)
        {
            db.HuurMateriaal(Materiaal, User, BeginDatum, EindDatum , Nudatum);
        }
    }
}
