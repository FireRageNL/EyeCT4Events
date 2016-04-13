using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Adress
    {
        public int AdresID { get; private set; }

        public string Street { get; private set; }

        public int Number { get; private set; }

        public string City { get; private set; }

        public string Country { get; private set; }

        public string Zipcode { get; private set; }

        public string Addition { get; private set; }

        public Adress(int aid, string str, int num, string cty, string cntry, string zip, string add)
        {
            AdresID = aid;
            Street = str;
            Number = num;
            City = cty;
            Country = cntry;
            Zipcode = zip;
            Addition = add;
        }
    }
}
