using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace EventClasses
{
    class DAL
    {
        public OracleConnection conn { get; private set; }

        public DAL(String connection)
        {
            conn = new OracleConnection();
            conn.ConnectionString = connection +";Data Source=" + "<database>" +
                                    ";";
        }

        public bool ExecuteDbCommand(string command)
        {
            return false;
        }
    }
}
