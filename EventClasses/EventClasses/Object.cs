using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    class Object
    {
        public int ObjectID { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }


        public Object(int id, string objname, string objdescription)
        {
            ObjectID = id;
            Name = objname;
            Description = objdescription;
        }
    }
}
