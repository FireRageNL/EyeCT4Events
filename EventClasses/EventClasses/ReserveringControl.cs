using System.Collections.Generic;

namespace EventClasses
{
    public class ReserveringControl
    {
        private readonly DbAdmin _db = new DbAdmin();

        public List<Group> GetEmptyGroups()
        {
            return _db.GetEmptyGroups();
        }

        public List<Location> GetFreeLocations(int count)
        {
            return _db.GetFreeLocations(count);
        }

        public void ReserveLocation(Group searchgroup, Location reserve)
        {
            _db.ReserveLocation(searchgroup, reserve);
        }
    }
}
