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

        public RFID Rfidtag { get; private set; }

        public string Emailadres { get; private set; }

        public List<TicketReservation> Reserve { get; private set; }

        public User(int uid, string uname, Adress add, RFID rf, string uemail, TicketReservation tickreserve = null)
        {
            UserID = uid;
            Name = uname;
            Adress.Add(add);
            Rfidtag = rf;
            Emailadres = uemail;
            if (tickreserve != null)
            {
                Reserve.Add(tickreserve);
            }
        }

        public User(int uid, string uname, string uemail)
        {
            UserID = uid;
            Name = uname;
            Emailadres = uemail;
        }

        public static User FindUser(string uname, string uemail)
        {
            if (uname == null)
            {
                //DB send command to find users by e-mail, build a new user var with the returned data and return this var
                return null;
            }
            if (uemail == null)
            {
                //DB send command to find users by name, build a new user var with the returned data and return this var
                return null;
            }
            return null;
        }

        public void UpdateUser(string uname, List<Adress> uadress, RFID rfid, string uemail, TicketReservation uReserve = null )
        {
            Name = uname;
            Adress = uadress;
            Rfidtag = rfid;
            Emailadres = uemail;
            if (uReserve != null)
            {
                Reserve.Add(uReserve);
            }
        }

        public void DeleteUser(User deluser)
        {
            //Code to delete user from database
        }
    }
}
