using System;
using System.Collections.Generic;

namespace EventClasses
{
    public class User
    {
        public int UserID { get;  private set; }

        public string Name { get; private set; }

        public Adress Adress { get; private set; }

        public string Emailadres { get; private set; }

        public List<TicketReservation> Reserve { get; private set; }

        public string Date { get; private set; }

        public Decimal Budget { get; private set; }

        public User(int uid, string uname, Adress add, string uemail, TicketReservation tickreserve = null)
        {
            UserID = uid;
            Name = uname;
            Adress = add;
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

        public User(int id, string naam, string email, string datum, decimal budget, Adress uadres)
        {
            UserID = id;
            Name = naam;
            Emailadres = email;
            Date = datum;
            Budget = budget;
            Adress = uadres;
        }

        public override string ToString()
        {
            return "   ID: " + UserID + "   Naam: " + Name + "   Email: " + Emailadres + "   Geboortedatum: " + Date;
        }

        public string GroupName => Name + " " + Emailadres;

        public void Update(string naam,string email, string datum, decimal budget)
        {
            Name = naam;
            Emailadres = email;
            Date = datum;
            Budget = budget;
        }
    }
}
