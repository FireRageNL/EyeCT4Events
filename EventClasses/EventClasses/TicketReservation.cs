using System.Collections.Generic;

namespace EventClasses
{
    public class TicketReservation
    {
        public int ReservationID { get; private set; }

        public User User { get; private set; }

        public bool Paymentfulfilled { get; private set; }

        public Event Event { get; private set; }

        public TicketReservation(User usr, Event evt, bool fulfilled = false)
        {
            User = usr;
            Event = evt;
            Paymentfulfilled = fulfilled;
            //add to DB and fetch ID
            int dbid = 1;
            ReservationID = dbid;
        }

        public static List<TicketReservation> GetReservations()
        {
            //Fetch all tickets from database and add them to the list
            return null;
        }

        public bool GetPaymentStatus()
        {
            bool rtn = false;
            rtn = Paymentfulfilled == true;
            return rtn;
        }

        public void UpdatePayment(bool status)
        {
            Paymentfulfilled = status;
        }
    }
}