using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
   public class Toegangscontrole
    {
        private DBAdmin db = new DBAdmin();
        public CheckIn CheckIn(int rfidTag)
        {
            return db.CheckIn(rfidTag);
        }

    }
}
