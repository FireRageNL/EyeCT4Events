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
        public string Type { get; private set; }
        public string Description { get; private set; }
        public decimal Rentprice { get; private set; }


        public Object(int objid, string objproductname, string objbrand, string objtype, string objdescription, decimal objrentprice)
        {
            ObjectID = objid;
            Productname = objproductname;
            Brand = objbrand;
            this.Type = objtype;
            Rentprice = objrentprice;
            Description = objdescription;
        }
    }
}
