using System;
using System.Collections.Generic;

namespace EventClasses
{
    public class Verhuurcontrole
    {
        private readonly DbAdmin _db = new DbAdmin();

        public int Huur(Object materiaal, User user, DateTime beginDatum, DateTime eindDatum , DateTime nudatum ,bool opgehaald)
        {
            int huur = _db.HuurMateriaal(materiaal, user, beginDatum, eindDatum , nudatum , opgehaald);
            if (huur == 1)
            {
                return 1;
            }
            if (huur == 2)
            {
                return 2;
            }
            return 3;
        }

        public List<ObjectReservation> GetReserved()
        {
            return _db.GetReserved();
        }

        public List<ObjectReservation> GetBorrowed()
        {
            return _db.GetBorrowed();
        }

        public void Borrow(ObjectReservation res)
        {
            _db.BorrowObject(res);
        }

        public void TakeBack(ObjectReservation res)
        {
            _db.TakeBackObject(res);
        }
    }
}
