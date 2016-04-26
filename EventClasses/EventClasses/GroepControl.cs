using System.Collections.Generic;

namespace EventClasses
{
    public class GroepControl
    {
        private readonly DbAdmin _db = new DbAdmin();

        public List<User> GetUsers()
        {
            return _db.BeheerUser();
        }

        public void AddGroup(List<User> groupUsers, string text)
        {
            _db.AddGroup(groupUsers, text);
        }
    }
}
