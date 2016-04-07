using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class DBAdmin
    {
        public DAL Dal { get; private set; }

        public DBAdmin(DAL dal)
        {
            
            Dal = dal;
        }

        public DataSet SendDbCommand(string command)
        {
            DataSet returnval = Dal.ExecuteDbCommand(command);
            return returnval;
        }
    }
}
