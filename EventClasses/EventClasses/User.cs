using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class User
    {
        public int UserID { get;  private set; }

        public string Name { get; private set; }

        public List<Adress> Adress { get; private set; }

        public string Emailadres { get; private set; }

        public List<TicketReservation> Reserve { get; private set; }

        public string Date { get; private set; }

        public Decimal Budget { get; private set; }

        public User(int uid, string uname, Adress add, string uemail, TicketReservation tickreserve = null)
        {
            UserID = uid;
            Name = uname;
            Adress.Add(add);
            Emailadres = uemail;
            if (tickreserve != null)
            {
                Reserve.Add(tickreserve);
            }
        }

        public User (int id, string naam , string email , string datum)
        {
            UserID = id;
            Name = naam;
            Emailadres = email;
            Date = datum;
        }

        public User(int uid, string uname, string uemail)
        {
            UserID = uid;
            Name = uname;
            Emailadres = uemail;
        }

        public override string ToString()
        {
            return "     ID: " + UserID + "     Naam: " + Name + "     Email: " + Emailadres + "     Geboortedatum: " + Date;
        }
    }
}
