using System;
using System.Collections.Generic;

namespace EventClasses
{
    public class Verhuurcontrole
    {
        private DBAdmin db = new DBAdmin();

        public int Huur(EventClasses.Object Materiaal, User User, DateTime BeginDatum, DateTime EindDatum , DateTime Nudatum ,bool Opgehaald , bool Teruggebracht)
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

        public List<ObjectReservation> GetReserved()
        {
            return db.GetReserved();
        }

        public List<ObjectReservation> GetBorrowed()
        {
            return db.GetBorrowed();
        }

        public void Borrow(ObjectReservation res)
        {
            db.BorrowObject(res);
        }

        public void TakeBack(ObjectReservation res)
        {
            db.TakeBackObject(res);
        }
    }
}
