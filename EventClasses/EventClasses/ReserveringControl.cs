using System.Collections.Generic;

namespace EventClasses
{
    public class ReserveringControl
    {
        private DBAdmin db = new DBAdmin();

        public List<Group> GetEmptyGroups()
        {
            return db.GetEmptyGroups();
        }

        public List<Location> GetFreeLocations(int count)
        {
            return db.GetFreeLocations(count);
        }

        public void ReserveLocation(Group searchgroup, Location reserve)
        {
            db.ReserveLocation(searchgroup, reserve);
        }
    }
}
