using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;



namespace EventClasses
{
    public class DAL
    {
        public OracleConnection conn { get; private set; }

        public DAL()
        {
            conn = new OracleConnection();
            conn.ConnectionString =
                "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = fhictora))); User ID = <OracleUsername>; PASSWORD = <OraclePass>";
        }

        public bool ExecuteDbCommand(string command)
        {
            conn.Open();
            //do stuff
            conn.Close();
            return false;
        }
    }
}
