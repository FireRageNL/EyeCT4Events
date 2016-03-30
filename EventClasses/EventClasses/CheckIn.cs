using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    class CheckIn
    {
        public RFID RfidTag { get; private set; }

        public bool CheckedIn { get; private set; }

        public void ChangeStatus()
        {
            if (this.CheckedIn == true)
            {
                this.CheckedIn = false;
            }
            else if(this.CheckedIn == false)
            {
                this.CheckedIn = true;
            }
        }
    }
}
