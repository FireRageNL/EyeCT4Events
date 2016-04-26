using System.Collections.Generic;

namespace EventClasses
{
    public class Group
    {
        public List<User> Users { get; }
        
        public int GroupId { get; private set; }

        private string Groupname { get; }

        public Group(string gname, int id, List<User> usr )
        {
            GroupId = id;
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
