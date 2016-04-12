using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
   public class Toegangscontrole
    {
        private DBAdmin db = new DBAdmin();

        public List<string> GetEvents()
        {
            return db.GetEvents();
        }
        public CheckIn CheckIn(int rfidTag, int eventid)
        {
            return db.CheckIn(rfidTag, eventid);
        }
        public Boolean Betaald(int rfidtag , int eventid)
        {
            return db.Betaald(rfidtag , eventid);
        }
    }
}
