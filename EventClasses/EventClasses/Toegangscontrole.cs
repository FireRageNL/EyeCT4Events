using System;
using System.Collections.Generic;

namespace EventClasses
{
    public class Toegangscontrole
    {
        private DBAdmin db = new DBAdmin();

        public List<string> GetEvents()
        {
            return db.GetEvents();
        }
        public CheckIn CheckIn(string rfidTag, int eventid)
        {
            return db.CheckIn(rfidTag, eventid);
        }
        public Boolean Betaald(string rfidtag , int eventid)
        {
            return db.Betaald(rfidtag , eventid);
        }

       public List<string> GetAanwezigheid(int evt)
       {
           return db.GetAanwezigheid(evt);
       }
    }
}
