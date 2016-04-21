using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class GroepControl
    {
        private DBAdmin db = new DBAdmin();

        public List<User> GetUsers()
        {
            return db.BeheerUser();
        }
    }
}
