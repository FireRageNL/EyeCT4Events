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
        public string Street { get; private set; }

        public string Number { get; private set; }

        public string City { get; private set; }

        public string Country { get; private set; }

        public string Zipcode { get; private set; }

        public Adress(string str, string num, string cty, string cntry, string zip)
        {
            Street = str;
            Number = num;
            City = cty;
            Country = cntry;
            Zipcode = zip;
            //push to db
        }

        public Adress FindAdress(string str)
        {
            //search on streetname
            return null;
        }

        public void UpdateAdress(string str, string num, string cty, string cntry, string zip)
        {
            Street = str;
            Number = num;
            City = cty;
            Country = cntry;
            Zipcode = zip;
            //push to db
        }

        public void DeleteAdress(Adress toDelete)
        {
            //delete from db
        }


    }
}
