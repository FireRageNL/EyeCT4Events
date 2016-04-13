using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class EventBeheerder
    {
        private DBAdmin db = new DBAdmin();


        public List<Event> GetEvents()
        {
            return db.GetEvent();
        }
    }
}
