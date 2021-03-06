﻿namespace EventClasses
{
    public class Adress
    {
        public string Street { get; private set; }

        public int Number { get; private set; }

        public string City { get; private set; }

        public string Country { get; private set; }

        public string Zipcode { get; private set; }

        public string Addition { get; private set; }

        public Adress(string str, int num, string cty, string cntry, string zip, string add)
        {
            Street = str;
            Number = num;
            City = cty;
            Country = cntry;
            Zipcode = zip;
            Addition = add;
        }

        public void Update(string str, int num, string cty, string cntry, string zip, string add)
        {
            Street = str;
            Number = num;
            City = cty;
            Country = cntry;
            Zipcode = zip;
            Addition = add;
        }
    }
}
