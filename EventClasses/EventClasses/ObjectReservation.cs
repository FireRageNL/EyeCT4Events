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

        public DateTime StartTime { get; private set; }

        public DateTime EndTime { get; private set; }

        public bool ObjectTaken { get; private set; }
        
        public User Usr { get; private set; }


        public ObjectReservation(int resid, int ruser, DateTime time)
        {
            ReservationID = resid;
            ResUser = ruser;
            ResTime = time;
        }

        public ObjectReservation(int resid, User ruser, DateTime start, DateTime end,Object obj)
        {
            ReservationID = resid;
            Usr = ruser;
            StartTime = start;
            EndTime = end;
            ResObject = obj;
        }

        public override string ToString()
        {
            return ReservationID + ": " + ResObject.Brand + " " + ResObject.Productname + " Verhuurd Van: " +
                   StartTime.ToShortDateString() + " Tot: " + EndTime.ToShortDateString() + " Aan: " + Usr.Name;
        }
    }
}
