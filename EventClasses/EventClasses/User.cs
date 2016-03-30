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
        public int UserID { get; set; }

        public string Name { get; set; }

        public List<Adress> Adres { get; set; }

        public RFID Rfidtag { get; set; }

        public string Emailadres { get; set; }

        public ObjectReservation Reserve { get; set; }

        public static User FindUser()
        {
            User returnuser = null;
            return returnuser;
        }

        public static void UpdateUser(User usrupdate)
        {
            // do stuff and such
        }
    }
}
