using System;
using System.Collections.Generic;

namespace EventClasses
{
    public class EventBeheerder
    {
        private readonly DbAdmin _db = new DbAdmin();


        public List<Event> GetEvents()
        {
            return _db.GetEvent();
        }

        public void AddEvent(string straat, int nr,string toe, string plaats, string postcode, string land, string naam, DateTime begin, DateTime end)
        {
            _db.AddEvent(straat, nr,toe, plaats, postcode, land, naam, begin, end);
        }
    }
}
