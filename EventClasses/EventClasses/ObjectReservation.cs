using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class ObjectReservation
    {
        public int ReservationID { get; private set; }

        public Object ResObject { get; private set; }

        public int ResUser { get; private set; }

        public DateTime ResTime { get; private set; }

        public bool ObjectTaken { get; private set; }


        public ObjectReservation(int resid, int ruser, DateTime time)
        {
            ReservationID = resid;
            ResUser = ruser;
            ResTime = time;
        }

    }
}
