using System;

namespace EventClasses
{
    public class ObjectReservation
    {
        public int ReservationId { get; }

        private Object ResObject { get; }

        public DateTime ResTime { get; private set; }

        private DateTime StartTime { get; }

        private DateTime EndTime { get; }

        private User Usr { get; }


        public ObjectReservation(int resid, DateTime time)
        {
            ReservationId = resid;
            ResTime = time;
        }

        public ObjectReservation(int resid, User ruser, DateTime start, DateTime end,Object obj)
        {
            ReservationId = resid;
            Usr = ruser;
            StartTime = start;
            EndTime = end;
            ResObject = obj;
        }

        public override string ToString()
        {
            return ReservationId + ": " + ResObject.Brand + " " + ResObject.Productname + " Verhuurd Van: " +
                   StartTime.ToShortDateString() + " Tot: " + EndTime.ToShortDateString() + " Aan: " + Usr.Name;
        }
    }
}
