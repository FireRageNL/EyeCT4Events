using System;
using System.Collections.Generic;
using System.Data;
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
                "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = fhictora))); User ID = dbi347373; PASSWORD = Testpassword1234";
        }

        public DataSet ExecuteDbCommand(string command)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = command;
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                OracleCommandBuilder cb = new OracleCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                conn.Close();
                return null;
            }
        }
    }
}
