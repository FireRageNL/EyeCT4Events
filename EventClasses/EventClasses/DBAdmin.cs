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
    public class DBAdmin
    {
        private OracleConnection conn = new OracleConnection();

        public DBAdmin()
        {
            conn.ConnectionString =
                            "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = fhictora))); User ID = dbi347373; PASSWORD = Testpassword1234";

        }

        public string CheckLogin(string uname)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Wachtwoord, Beheerder FROM Gebruiker WHERE Email='" + uname + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string li = null;
                if (dr.HasRows)
        {
                    li = dr.GetString(0) + "," + dr.GetInt32(1);
                }
                conn.Close();
                return li;
        }
            catch (OracleException e)
        {
                Console.WriteLine("Message: " + e.Message);
                conn.Close();
                return null;
            }
        }

        public CheckIn CheckIn(int rfidtag)
        {

        }

        //Checkin
        public string checkname()
        {
            //Naam bezoeker checken
            DataTable dtnaam = new DataTable();
            string dbcommandnaam = "Select g.Naam from gebruiker g inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode =" + rfidtag;
            DataSet naam = DatabaseAdmin.SendDbCommand(dbcommandnaam);
            dtnaam = naam.Tables[0];
            string Naam = dtnaam.Rows[0][0].ToString();

            //Aanwezigheid Checken/Aanpassen
            DataTable dtaanwezig = new DataTable();
            string dbcommandaanwezig = "Select a.Aanwezigheid from Aanwezig a inner join gebruiker g on a.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet aanwezig = DatabaseAdmin.SendDbCommand(dbcommandaanwezig);
            dtaanwezig = aanwezig.Tables[0];
            int Aanwezig = Convert.ToInt32(dtaanwezig.Rows[0][0].ToString());

            if (Aanwezig == 1)
            {
                Aanwezig = 0;
                string dbchangestatus = "update Aanwezigheid from Aanwezig where Aanwezigheid = 0";
                DatabaseAdmin.SendDbCommandvoid(dbchangestatus);
            }
            else if (Aanwezig == 0)
            {
                Aanwezig = 1;
                string dbchangestatus = "update Aanwezigheid from Aanwezig where Aanwezigheid = 1";
                DatabaseAdmin.SendDbCommandvoid(dbchangestatus);
            }

            //Betaaldstatus checken
            DataTable dtbetaald = new DataTable();
            string dbcommandbetaald = "Select t.Betaald from Toegangsreservering t inner join gebruiker g on t.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet betaald = DatabaseAdmin.SendDbCommand(dbcommandbetaald);
            dtbetaald = betaald.Tables[0];
            int Betaald = Convert.ToInt32(dtbetaald.Rows[0][0].ToString());
            Boolean Payment = false;

            if (Betaald == 1)
            {
                Payment = true;
            }
            else if (Betaald == 0)
            {
                Payment = false;
            }

            //return
            CheckIn rtrn = new EventClasses.CheckIn(rfidtag, Naam, Aanwezig , Payment);
            return rtrn;
        }
    }
}

