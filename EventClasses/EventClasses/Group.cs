using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    class Group
    {
        public List<User> Users { get; private set; }
        
        public int GroupID { get; private set; }
        
        public string Groupname { get; private set; } 

        public Location Loc { get; private set; }

        public Group(string gname, int id)
        {
            GroupID = id;
            Groupname = gname;
        }

        public void AddUserToGroup(User usr)
        {
            Users.Add(usr);
        }
    }
}
