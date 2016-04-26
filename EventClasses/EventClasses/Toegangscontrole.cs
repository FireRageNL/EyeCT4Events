using System.Collections.Generic;

namespace EventClasses
{
    public class Toegangscontrole
    {
        private readonly DbAdmin _db = new DbAdmin();

        public List<string> GetEvents()
        {
            return _db.GetEvents();
        }
        public CheckIn CheckIn(string rfidTag, int eventid)
        {
            return _db.CheckIn(rfidTag, eventid);
        }
        public bool Betaald(string rfidtag , int eventid)
        {
            return _db.Betaald(rfidtag , eventid);
        }

       public List<string> GetAanwezigheid(int evt)
       {
           return _db.GetAanwezigheid(evt);
       }
    }
}
