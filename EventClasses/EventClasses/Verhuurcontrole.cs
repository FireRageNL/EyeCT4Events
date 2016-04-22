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

        public int Huur(EventClasses.Object Materiaal, EventClasses.User User, DateTime BeginDatum, DateTime EindDatum , DateTime Nudatum ,bool Opgehaald , bool Teruggebracht)
        {
            int huur = db.HuurMateriaal(Materiaal, User, BeginDatum, EindDatum , Nudatum , Opgehaald , Teruggebracht);
            if (huur == 1)
            {
                return 1;
            }
            else if (huur == 2)
            {
                return 2;
            }
                return 3;
        }
    }
}
