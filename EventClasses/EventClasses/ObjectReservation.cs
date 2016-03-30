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

        public User ResUser { get; private set; }

        public DateTime ResTime { get; private set; }

        public bool ObjectTaken { get; private set; }


        public ObjectReservation(int resid, Object robject, User ruser, DateTime time)
        {
            ReservationID = resid;
            ResObject = robject;
            ResUser = ruser;
            ResTime = time;
        }

        public static List<ObjectReservation> GetFreeObjects(DateTime time)
        {
            return null;
        }

        public void DispatchObject()
        {
            ObjectTaken = true;
        }

        public void ReturnObject()
        {
            ObjectTaken = false;
        }
    }
}
