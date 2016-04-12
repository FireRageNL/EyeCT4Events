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
                cmd.BindByName = true;
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Wachtwoord, Beheerder FROM Gebruiker WHERE Email= :param";
                cmd.Parameters.Add("param", uname);
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
        
        public List<string> GetEvents()
        {
            List<string> rtn = new List<string>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select Eventnaam from Event";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                        rtn.Add(dr.GetString(0));
                }
                conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                conn.Close();
                return null;
            }

        }
        //Checkin
        public CheckIn CheckIn(int rfidtag, int eventid)
        {
            string Naam = null;
            int Aanwezig = 0;
            Boolean Payment = false;

            //Naam bezoeker checken
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "Select g.Voornaam , g.Achternaam from gebruiker g inner join bandje b on g.gebruikerid = b.gebruikerid inner join Toegangsreservering t on g.gebruikerid = t.gebruikerid where b.RFIDcode = :param and t.eventid = :par";
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    Naam = dr.GetString(0) + " " + dr.GetString(1);
                }
                conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                conn.Close();
                return null;
            }


            // Aanwezigheid checken
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "Select a.Aanwezigheid from Aanwezig a inner join gebruiker g on a.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RFIDcode = :param and a.eventid = :par";
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    Aanwezig = dr.GetInt32(0);
                    if (Aanwezig == 1)
                    {
                        Aanwezig = 0;
                        cmd.CommandText = "update Aanwezig SET Aanwezigheid = 0 where gebruikerid = (select gebruikerid from bandje where RFIDcode = :param)and eventid = :par";
                        cmd.Parameters.Add("param", rfidtag);
                        cmd.Parameters.Add("par", eventid);
                        cmd.ExecuteNonQuery();
                    }
                    else if (Aanwezig == 0)
                    {
                        Aanwezig = 1;
                        cmd.CommandText = "update Aanwezig SET Aanwezigheid = 1 where gebruikerid = (select gebruikerid from bandje where RFIDcode = :param) and eventid = :par";
                        cmd.Parameters.Add("param", rfidtag);
                        cmd.Parameters.Add("par", eventid);
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                conn.Close();
                return null;
            }


            //Betaaldstatus checken
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "Select t.Betaald from Toegangsreservering t inner join gebruiker g on t.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RFIDcode = :param and eventid = :par";
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int Betaald = dr.GetInt32(0);

                    if (Betaald == 1)
                    {
                        Payment = true;
                    }
                    else if (Betaald == 0)
                    {
                        Payment = false;
                    }
                }
                conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                conn.Close();
                return null;
            }

            //return
            CheckIn rtrn = new EventClasses.CheckIn(rfidtag, Naam, Aanwezig , Payment);
            return rtrn;
        }

        public Boolean Betaald(int rfidtag , int eventid)
        {
            // gebruiker op heeft betaald zetten
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "update Toegangsreservering SET Betaald = 1 where gebruikerid = (select gebruikerid from bandje where RFIDcode = :param)and eventid = :par";
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int Betaald = dr.GetInt32(0);
                }
                conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                conn.Close();
                return false;
            }

            return true;
        }
    }
}

