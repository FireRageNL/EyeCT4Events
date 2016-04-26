using System.Collections.Generic;

namespace EventClasses
{
    public class Group
    {
        public List<User> Users { get; private set; }
        
        public int GroupID { get; private set; }
        
        public string Groupname { get; private set; } 

        public Location Loc { get; set; }

        public Group(string gname, int id, List<User> usr )
        {
            GroupID = id;
            Groupname = gname;
            Users = usr;
        }

        public override string ToString()
        {
            if (Users.Count == 1)
            {
                return Groupname + " - " + Users.Count + " Persoon";
            }
            return Groupname + " - " + Users.Count+ " Personen";
        }
    }
}
