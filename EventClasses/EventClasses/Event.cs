using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Event
    {
        public Adress EventAddress { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public int EventID { get; private set; }


        public Event(Adress adr, string nme, string desc, int id)
        {
            EventAddress = adr;
            Name = nme;
            Description = desc;
            EventID = id;
        }

        public void UpdateEvent(Adress uadr = null, string uname = null, string udesc = null)
        {
            if (uadr != null)
            {
                EventAddress = uadr;
            }
            if (uname != null)
            {
                Name = uname;
            }
            if (udesc != null)
            {
                Description = udesc;
            }
        }
    }
}
