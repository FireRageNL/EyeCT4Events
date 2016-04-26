using System;
using System.Collections.Generic;

namespace EventClasses
{
    public class EventBeheerder
    {
        private DBAdmin db = new DBAdmin();


        public List<Event> GetEvents()
        {
            return db.GetEvent();
        }

        public void AddEvent(string straat, int nr,string toe, string plaats, string postcode, string land, string naam, DateTime begin, DateTime end)
        {
            db.AddEvent(straat, nr,toe, plaats, postcode, land, naam, begin, end);
        }
    }
}
