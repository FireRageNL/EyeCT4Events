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

        public int EventID { get; private set; }


        public Event(Adress adr, string nme, int id)
        {
            EventAddress = adr;
            Name = nme;
            EventID = id;
        }
    }
}
