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

        public List<Object> Geenmerk(string productnaam , int type)
            {

            List<Object> rtn = new List<Object>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select * from Materiaal where Productnaam = :param and TypeNR = :par";
                cmd.Parameters.Add("param", productnaam);
                cmd.Parameters.Add("par", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string Productname = (dr.GetString(2));
                    int Type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, Productname, Type, prijs);
                    rtn.Add(toAdd);
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

        public List<Object> Geenproductnaam(string Merk, int type)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select * from Materiaal where Merk = :param and TypeNR = :par";
                cmd.Parameters.Add("param", Merk);
                cmd.Parameters.Add("par", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string Productname = (dr.GetString(2));
                    int Type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, Productname, Type, prijs);
                    rtn.Add(toAdd);
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

        public List<Object> Geentype(string Merk, string productnaam)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select * from Materiaal where Merk = :param and Productnaam = :par";
                cmd.Parameters.Add("param", Merk);
                cmd.Parameters.Add("par", productnaam);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string Productname = (dr.GetString(2));
                    int Type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, Productname, Type, prijs);
                    rtn.Add(toAdd);
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

        public List<Object> Alleenmerk (string Merk)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select * from Materiaal where Merk = :param";
                cmd.Parameters.Add("param", Merk);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string Productname = (dr.GetString(2));
                    int Type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, Productname, Type, prijs);
                    rtn.Add(toAdd);
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

        public List<Object> Alleentype(int type)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select * from Materiaal where TypeNR = :param";
                cmd.Parameters.Add("param", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string Productname = (dr.GetString(2));
                    int Type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, Productname, Type, prijs);
                    rtn.Add(toAdd);
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

        public List<Object> Alleenproductnaam(string Alleenproductnaam)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select * from Materiaal where Productnaam = :param";
                cmd.Parameters.Add("param", Alleenproductnaam);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string Productname = (dr.GetString(2));
                    int Type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, Productname, Type, prijs);
                    rtn.Add(toAdd);
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

        public List<Object> Alles(string productnaam , string merk , int type)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.BindByName = true;
                cmd.CommandText = "select * from Materiaal where Productnaam = :param and Merk = :para and TypeNr = :par";
                cmd.Parameters.Add("param", productnaam);
                cmd.Parameters.Add("para", merk);
                cmd.Parameters.Add("par", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string Merk = (dr.GetString(1));
                    string Productname = (dr.GetString(2));
                    int Type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, Merk, Productname, Type, prijs);
                    rtn.Add(toAdd);
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

        public List<string> GetPosts()
        {
            List<string> rtn = new List<string>();

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select Berichtid FROM Bericht WHERE ParentID IS NULL";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rtn.Add(dr.GetInt32(0).ToString());
                }
                conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: "+ e.Message);
                conn.Close();
                return null;
            }
        }
    }
}

