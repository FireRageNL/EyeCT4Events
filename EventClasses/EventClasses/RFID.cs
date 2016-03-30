using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class RFID
    {
        public User Usr { get; set; }

        public int RfidTag { get; private set; }

        public decimal Funds { get; private set; }


        public void UpdateFunds(decimal update)
        {
            Funds += update;
            int i = 0;
        }


    }
}
