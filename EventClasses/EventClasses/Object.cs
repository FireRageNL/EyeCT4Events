using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Object
    {
        public int ObjectID { get; private set; }
        public string Productname { get; private set; }
        public string Brand{ get; private set; }
        public int Type { get; private set; }
        public decimal Rentprice { get; private set; }


        public Object(int objid,  string objbrand , string objproductname,  int objtype , decimal objrentprice)
        {
            ObjectID = objid;
            Productname = objproductname;
            Brand = objbrand;
            Type = objtype;
            Rentprice = objrentprice;
        }

        public void Update(string brand, string product, int typenr, int price)
        {
            Productname = product;
            Brand = brand;
            Type = typenr;
            Rentprice = Convert.ToDecimal(price);
        }

        public override string ToString()
        {
            return "     ID: " + ObjectID + "     Productnaam: " + Productname + "     Merk: " + Brand + "     Type: " + Type;
        }
    }
}
