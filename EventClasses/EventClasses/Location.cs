using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    class Location
    {
        public int LocationID { get; private set; }

        public string Description { get; private set; }

        public Group UserGroup { get; private set; }

        public static List<Location> Spaces { get; private set; }
        
        public bool Taken { get; private set; }

        public Event Event { get; private set; }

        public Location(string desc, Event evt)
        {
            Description = desc;
            UserGroup = null;
            Taken = false;
            Event = evt;
            //Send to DB and fetch LocationID
            int dblocid = 1;
            LocationID = dblocid;
        }

        public void AddLoc(Location add)
        {
            Spaces.Add(add);
        }

        public static List<Location> GetFreeLocations()
        {
            List<Location> returnloc = null;
            foreach (Location search in Spaces)
            {
                if (search.Taken == false)
                {
                    returnloc.Add(search);
                }
            }
            return returnloc;
        }
        public static List<Location> GetTakenLocations()
        {
            List<Location> returnloc = null;
            foreach (Location search in Spaces)
            {
                if (search.Taken == true)
                {
                    returnloc.Add(search);
                }
            }
            return returnloc;
        }

        public void AddGroup(Group group)
        {
            UserGroup = group;
        }

        public void RemoveGroup()
        {
            UserGroup = null;
        }
    }
}
