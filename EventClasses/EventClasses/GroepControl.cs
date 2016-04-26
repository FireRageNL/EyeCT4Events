using System.Collections.Generic;

namespace EventClasses
{
    public class GroepControl
    {
        private DBAdmin db = new DBAdmin();

        public List<User> GetUsers()
        {
            return db.BeheerUser();
        }

        public void AddGroup(List<User> groupUsers, string text)
        {
            db.AddGroup(groupUsers, text);
        }
    }
}
