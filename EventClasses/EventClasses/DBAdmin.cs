using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EventClasses
{
    public class DbAdmin
    {
        private readonly OracleConnection _conn = new OracleConnection();

        public DbAdmin()
        {
            _conn.ConnectionString =
                            "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = fhictora))); User ID = dbi347373; PASSWORD = Testpassword1234";
        }
        //Check if email and password are correct
        public string CheckLogin(string uname)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    BindByName = true,
                    Connection = _conn,
                    CommandText = "SELECT Wachtwoord, Beheerder FROM Gebruiker WHERE Email= :param"
                };
                cmd.Parameters.Add("param", uname);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string li = null;
                if (dr.HasRows)
                {
                    li = dr.GetString(0) + "," + dr.GetInt32(1);
                }
                _conn.Close();
                return li;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }
        //Fetch the data about a user using e-mail address
        public User GetUser(string uemail, bool intrnl = false)
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                OracleCommand cmd = new OracleCommand
                {
                    BindByName = true,
                    Connection = _conn,
                    CommandText = "SELECT GebruikerID, Voornaam, Achternaam FROM Gebruiker WHERE Email= :param"
                };
                cmd.Parameters.Add("param", uemail);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int uid = dr.GetInt32(0);
                string name = dr.GetString(1) + " " + dr.GetString(2);
                if (!intrnl)
                {
                    _conn.Close();
                }
                User rtn = new User(uid, name, uemail);
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }
        //fetch the data about a user using userID
        private User GetUser(int uid, bool intrnl = false)
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                OracleCommand cmd = new OracleCommand
                {
                    BindByName = true,
                    Connection = _conn,
                    CommandText = "SELECT email, Voornaam, Achternaam FROM Gebruiker WHERE Gebruikerid= :param"
                };
                cmd.Parameters.Add("param", uid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string email = dr.GetString(0);
                string name = dr.GetString(1) + " " + dr.GetString(2);
                if (!intrnl)
                {
                    _conn.Close();
                }
                User rtn = new User(uid, name, email);
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }
        //Get all events
        public List<string> GetEvents()
        {
            List<string> rtn = new List<string>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    CommandText = "Select Eventnaam from Event"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rtn.Add(dr.GetString(0));
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }
        //Checkin
        public CheckIn CheckIn(string rfidtag, int eventid)
        {
            string naam = null;
            bool payment = false;

            //Naam bezoeker checken
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "Select g.Voornaam , g.Achternaam from gebruiker g inner join bandje b on g.gebruikerid = b.gebruikerid inner join Toegangsreservering t on g.gebruikerid = t.gebruikerid where b.RFIDcode = :param and t.eventid = :par"
                };
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    naam = dr.GetString(0) + " " + dr.GetString(1);
                }
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }


            // Aanwezigheid checken
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "Select a.Aanwezigheid from Aanwezig a inner join gebruiker g on a.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RFIDcode = :param and a.eventid = :par"
                };
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int aanwezig = dr.GetInt32(0);
                    if (aanwezig == 1)
                    {
                        cmd.CommandText =
                            "update Aanwezig SET Aanwezigheid = 0 where gebruikerid = (select gebruikerid from bandje where RFIDcode = :param)and eventid = :par";
                        cmd.Parameters.Add("param", rfidtag);
                        cmd.Parameters.Add("par", eventid);
                        cmd.ExecuteNonQuery();
                    }
                    else if (aanwezig == 0)
                    {
                        cmd.CommandText =
                            "update Aanwezig SET Aanwezigheid = 1 where gebruikerid = (select gebruikerid from bandje where RFIDcode = :param) and eventid = :par";
                        cmd.Parameters.Add("param", rfidtag);
                        cmd.Parameters.Add("par", eventid);
                        cmd.ExecuteNonQuery();
                    }
                }
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }


            //Betaaldstatus checken
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "Select t.Betaald from Toegangsreservering t inner join gebruiker g on t.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RFIDcode = :param and eventid = :par"
                };
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    int betaald = dr.GetInt32(0);

                    if (betaald == 1)
                    {
                        payment = true;
                    }
                }
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

            //return
            CheckIn rtrn = new CheckIn(naam, payment);
            return rtrn;
        }

        public bool Betaald(string rfidtag, int eventid)
        {
            // gebruiker op heeft betaald zetten
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "update Toegangsreservering SET Betaald = 1 where gebruikerid = (select gebruikerid from bandje where RFIDcode = :param)and eventid = :par"
                };
                cmd.Parameters.Add("param", rfidtag);
                cmd.Parameters.Add("par", eventid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return false;
            }

            return true;
        }

        public List<Object> Geenmerk(string productnaam, int type)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Materiaal where Productnaam = :param and TypeNR = :par"
                };
                cmd.Parameters.Add("param", productnaam);
                cmd.Parameters.Add("par", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<Object> Geenproductnaam(string merk, int type)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Materiaal where Merk = :param and TypeNR = :par"
                };
                cmd.Parameters.Add("param", merk);
                cmd.Parameters.Add("par", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<Object> Geentype(string merk, string productnaam)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Materiaal where Merk = :param and Productnaam = :par"
                };
                cmd.Parameters.Add("param", merk);
                cmd.Parameters.Add("par", productnaam);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    int type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<Object> Alleenmerk(string merk)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Materiaal where Merk = :param"
                };
                cmd.Parameters.Add("param", merk);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    int type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<Object> Alleentype(int type)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Materiaal where TypeNR = :param"
                };
                cmd.Parameters.Add("param", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<Object> Alleenproductnaam(string alleenproductnaam)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Materiaal where Productnaam = :param"
                };
                cmd.Parameters.Add("param", alleenproductnaam);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    int type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<Object> Alles(string productnaam, string merk, int type)
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "select * from Materiaal where Productnaam = :param and Merk = :para and TypeNr = :par"
                };
                cmd.Parameters.Add("param", productnaam);
                cmd.Parameters.Add("para", merk);
                cmd.Parameters.Add("par", type);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }
        //Fetch all main posts in the database
        public List<string> GetPosts()
        {
            List<string> rtn = new List<string>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    CommandText = "Select Berichtid FROM Bericht WHERE ParentID IS NULL ORDER BY berichtid"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rtn.Add(dr.GetInt32(0).ToString());
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }
        //Fetch the contents of a post, including replies
        public List<Message> GetContents(int postid)
        {
            List<Message> rtn = new List<Message>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "SELECT Gebruikerid, mediaid, inhoud FROM bericht WHERE berichtid =:par ORDER BY BERICHTID"
                };
                cmd.Parameters.Add("par", postid);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int puid = dr.GetInt32(0);
                int mediaid = 0;
                if (!dr.IsDBNull(1))
                {
                    mediaid = dr.GetInt32(1);
                }
                string cont = dr.GetString(2);
                string floc = null;
                if (mediaid != 0)
                {
                    cmd.CommandText = "SELECT Bestandslocatie FROM media WHERE mediaid=" + mediaid;
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    floc = dr2.GetString(0);
                }
                Message parent = new Media(cont, GetUser(puid, true), postid, floc);
                rtn.Add(parent);
                cmd.CommandText = "Select Berichtid, gebruikerid, inhoud FROM Bericht WHERE ParentID = :par";
                cmd.Parameters.Add("par", postid);
                OracleDataReader dr3 = cmd.ExecuteReader();
                while (dr3.Read())
                {
                    int mid = dr3.GetInt32(0);
                    int uid = dr3.GetInt32(1);
                    string inh = dr3.GetString(2);
                    User usr = GetUser(uid, true);
                    Message msg = new Message(inh, usr, mid, parent);
                    rtn.Add(msg);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }

        // Post a reply to a post into the database
        public void PostReply(string message, Media parent, int userid)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "INSERT INTO BERICHT(GEBRUIKERID, PARENTID, INHOUD) VALUES(:usrid,:pid,:inh)"
                };
                cmd.Parameters.Add("usrid", userid);
                cmd.Parameters.Add("pid", parent.MessageId);
                cmd.Parameters.Add("inh", message);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }
        //Create a new post in the database
        public void NewPost(string message, string url, string type, Login val)
        {
            try
            {
                Media parent = null;
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true
                };
                if (url != null)
                {
                    cmd.CommandText =
                        "INSERT INTO MEDIA(GEBRUIKERID, SOORTMEDIA,BESTANDSLOCATIE) VALUES(:userid,:soort,:locatie)";
                    cmd.Parameters.Add("userid", val.User.UserId);
                    cmd.Parameters.Add("soort", type);
                    cmd.Parameters.Add("locatie", url);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =
                        "SELECT MEDIAID FROM MEDIA WHERE GEBRUIKERID = :userid AND SOORTMEDIA = :soort AND BESTANDSLOCATIE = :locatie";
                    cmd.Parameters.Add("userid", val.User.UserId);
                    cmd.Parameters.Add("soort", type);
                    cmd.Parameters.Add("locatie", url);
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    int mid = dr.GetInt32(0);
                    parent = new Media(message, val.User, mid, url);
                }
                if (parent != null)
                {
                    cmd.CommandText = "INSERT INTO BERICHT(GEBRUIKERID, MEDIAID, INHOUD) VALUES(:usrid,:medid,:inh)";
                    cmd.Parameters.Add("usrid", val.User.UserId);
                    cmd.Parameters.Add("medid", parent.MessageId);
                    cmd.Parameters.Add("inh", message);
                }
                else
                {
                    cmd.CommandText = "INSERT INTO BERICHT(GEBRUIKERID, INHOUD) VALUES(:usrid,:inh)";
                    cmd.Parameters.Add("usrid", val.User.UserId);
                    cmd.Parameters.Add("inh", message);
                }
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public List<Object> BeheerMateriaal()
        {

            List<Object> rtn = new List<Object>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Materiaal ORDER BY MateriaalID"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string merk = (dr.GetString(1));
                    string productname = (dr.GetString(2));
                    int type = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    Object toAdd = new Object(id, merk, productname, type, prijs);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public void DeleteMateriaal(Object deleteMateriaal)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "DELETE FROM Materiaal WHERE MateriaalID = :param"
                };
                cmd.Parameters.Add("param", deleteMateriaal.ObjectId);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public void AddProduct(string brand, string product, int typenr, int price)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "INSERT INTO MATERIAAL(MERK,PRODUCTNAAM,TYPENR,PRIJS) VALUES(:mrk,:prdnm,:typenr,:price)"
                };
                cmd.Parameters.Add("mrk", brand);
                cmd.Parameters.Add("prdnm", product);
                cmd.Parameters.Add("typenr", typenr);
                cmd.Parameters.Add("price", price);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public void UpdateProduct(Object obj)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "UPDATE MATERIAAL SET Merk = :mrk, PRODUCTNAAM =:prdnm, TYPENR =:typenr, PRIJS =:price WHERE MATERIAALID = " +
                        obj.ObjectId
                };
                cmd.Parameters.Add("mrk", obj.Brand);
                cmd.Parameters.Add("prdnm", obj.Productname);
                cmd.Parameters.Add("typenr", obj.Type);
                cmd.Parameters.Add("price", obj.Rentprice);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public List<string> GetAanwezigheid(int evt)
        {
            List<string> rtn = new List<string>();
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "select a.aanwezigheid, g.voornaam, g.achternaam FROM aanwezig a, gebruiker g WHERE g.gebruikerid = a.gebruikerid AND a.EVENTID =" +
                        evt
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int aanwezig = dr.GetInt32(0);
                    string voornaam = dr.GetString(1);
                    string achternaam = dr.GetString(2);
                    if (aanwezig == 1)
                    {
                        string toAdd = voornaam + " " + achternaam;
                        rtn.Add(toAdd);
                    }

                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }
        public List<User> Geenachternaam(string email, string datum)
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Gebruiker where email = :param and geboortedatum = :par"
                };
                cmd.Parameters.Add("param", email);
                cmd.Parameters.Add("par", datum);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    email = (dr.GetString(6));
                    datum = (dr.GetOracleDate(5).ToString());
                    User toAdd = new User(id, naam, email, datum);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<User> Geenemail(string achternaam, string datum)
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Gebruiker where achternaam = :param and geboortedatum = :par"
                };
                cmd.Parameters.Add("param", achternaam);
                cmd.Parameters.Add("par", datum);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    string email = (dr.GetString(6));
                    datum = (dr.GetOracleDate(5).ToString());

                    User toAdd = new User(id, naam, email, datum);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<User> Geendatum(string achternaam, string email)
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Gebruiker where achternaam = :param and email = :par"
                };
                cmd.Parameters.Add("param", achternaam);
                cmd.Parameters.Add("par", email);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    email = (dr.GetString(6));
                    string datum = (dr.GetOracleDate(5).ToString());
                    User toAdd = new User(id, naam, email, datum);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<User> Alleenachternaam(string achternaam)
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Gebruiker where achternaam = :param"
                };
                cmd.Parameters.Add("param", achternaam);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    string email = (dr.GetString(6));
                    string datum = (dr.GetOracleDate(5).ToString());
                    User toAdd = new User(id, naam, email, datum);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<User> Alleendatum(string datum)
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Gebruiker where geboortedatum = :param"
                };
                cmd.Parameters.Add("param", datum);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    string email = (dr.GetString(6));
                    datum = (dr.GetOracleDate(5).ToString());
                    User toAdd = new User(id, naam, email, datum);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<User> Alleenemail(string email)
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Gebruiker where email = :param"
                };
                cmd.Parameters.Add("param", email);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    email = (dr.GetString(6));
                    string datum = (dr.GetOracleDate(5).ToString());
                    User toAdd = new User(id, naam, email, datum);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public List<User> Alles(string email, string achternaam, string datum)
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "select * from Gebruiker where email = :param and achternaam = :para and geboortedatum = :par"
                };
                cmd.Parameters.Add("param", email);
                cmd.Parameters.Add("para", achternaam);
                cmd.Parameters.Add("par", datum);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    email = (dr.GetString(6));
                    datum = (dr.GetOracleDate(5).ToString());
                    User toAdd = new User(id, naam, email, datum);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }
        public void DeleteUser(User deleteUser)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "DELETE FROM Gebruiker WHERE GebruikerID = :param"
                };
                cmd.Parameters.Add("param", deleteUser.UserId);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }
        public List<User> BeheerUser()
        {

            List<User> rtn = new List<User>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "select * from Gebruiker"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string naam = dr.GetString(3) + " " + dr.GetString(4);
                    string email = (dr.GetString(6));
                    string datum = (dr.GetOracleDate(5).ToString());
                    decimal budget = (dr.GetDecimal(8));
                    Adress uadres = GetUserAddress(dr.GetInt32(1));
                    User toAdd = new User(id, naam, email, datum, budget, uadres);
                    rtn.Add(toAdd);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }

        }

        public void UpdateUser(User user, string wachtwoord = null)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true
                };
                if (user.Adress.Addition != null)
                {
                    cmd.CommandText =
                        "Select count(*) from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer AND toevoeging=:toe";
                    cmd.Parameters.Add("land", user.Adress.Country);
                    cmd.Parameters.Add("postcode", user.Adress.Zipcode);
                    cmd.Parameters.Add("plaats", user.Adress.City);
                    cmd.Parameters.Add("straatnaam", user.Adress.Street);
                    cmd.Parameters.Add("nummer", user.Adress.Number);
                    cmd.Parameters.Add("toe", user.Adress.Addition);
                }
                else
                {
                    cmd.CommandText =
                        "Select count(*) from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", user.Adress.Country);
                    cmd.Parameters.Add("postcode", user.Adress.Zipcode);
                    cmd.Parameters.Add("plaats", user.Adress.City);
                    cmd.Parameters.Add("straatnaam", user.Adress.Street);
                    cmd.Parameters.Add("nummer", user.Adress.Number);
                }
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int count = dr.GetInt32(0);
                int adresid;
                if (count != 0)
                {
                    cmd.CommandText =
                        "Select adresid from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", user.Adress.Country);
                    cmd.Parameters.Add("postcode", user.Adress.Zipcode);
                    cmd.Parameters.Add("plaats", user.Adress.City);
                    cmd.Parameters.Add("straatnaam", user.Adress.Street);
                    cmd.Parameters.Add("nummer", user.Adress.Number);
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    adresid = dr2.GetInt32(0);
                }
                else
                {
                    cmd.CommandText =
                        "INSERT INTO ADRES(LAND,POSTCODE,WOONPLAATS,STRAATNAAM,HUISNUMMER,TOEVOEGING) VALUES(:land,:postcode,:plaats,:straatnaam,:nummer,:toe)";
                    cmd.Parameters.Add("land", user.Adress.Country);
                    cmd.Parameters.Add("postcode", user.Adress.Zipcode);
                    cmd.Parameters.Add("plaats", user.Adress.City);
                    cmd.Parameters.Add("straatnaam", user.Adress.Street);
                    cmd.Parameters.Add("nummer", user.Adress.Number);
                    cmd.Parameters.Add("toe", user.Adress.Addition);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =
                        "Select adresid from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", user.Adress.Country);
                    cmd.Parameters.Add("postcode", user.Adress.Zipcode);
                    cmd.Parameters.Add("plaats", user.Adress.City);
                    cmd.Parameters.Add("straatnaam", user.Adress.Street);
                    cmd.Parameters.Add("nummer", user.Adress.Number);
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    adresid = dr2.GetInt32(0);
                }
                if (wachtwoord != null)
                {
                    cmd.CommandText = "UPDATE Gebruiker SET Voornaam = :vn, Achternaam =:an, Wachtwoord =:ww, AdresID =:ai , Geboortedatum =:gb , Email =:em , Budget =:bg WHERE Gebruikerid = " + user.UserId;
                    string[] names = user.Name.Split(' ');
                    int nameslenght = names.Length;
                    cmd.Parameters.Add("vn", names[0]);
                    string lastname = null;
                    for (int i = 1; i < nameslenght; i++)
                    {
                        lastname += names[i] + " ";
                    }
                    if (lastname != null) cmd.Parameters.Add("an", lastname.Trim());
                    cmd.Parameters.Add("ww", wachtwoord);
                    cmd.Parameters.Add("ai", adresid);
                    cmd.Parameters.Add("gb", user.Date);
                    cmd.Parameters.Add("em", user.Emailadres);
                    cmd.Parameters.Add("bg", user.Budget);
                }
                else
                {
                    cmd.CommandText = "UPDATE Gebruiker SET Voornaam = :vn, Achternaam =:an, AdresID =:ai , Geboortedatum =:gb , Email =:em , Budget =:bg WHERE Gebruikerid = " + user.UserId;
                    string[] names = user.Name.Split(' ');
                    int nameslenght = names.Length;
                    cmd.Parameters.Add("vn", names[0]);
                    string lastname = null;
                    for (int i = 1; i < nameslenght; i++)
                    {
                        lastname += names[i] + " ";
                    }
                    if (lastname != null) cmd.Parameters.Add("an", lastname.Trim());
                    cmd.Parameters.Add("ai", adresid);
                    DateTime add = Convert.ToDateTime(user.Date);
                    cmd.Parameters.Add("gb", add);
                    cmd.Parameters.Add("em", user.Emailadres);
                    cmd.Parameters.Add("bg", user.Budget);
                }
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }
        public void AddUser(string naam, string wachtwoord, string date, string email, decimal budget, string straat, int nr, string toe, string plaats, string postcode, string land)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true
                };
                if (toe != null)
                {
                    cmd.CommandText =
                        "Select count(*) from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer AND toevoeging=:toe";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    cmd.Parameters.Add("toe", toe);
                }
                else
                {
                    cmd.CommandText =
                        "Select count(*) from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                }
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int count = dr.GetInt32(0);
                int adresid;
                if (count != 0)
                {
                    cmd.CommandText =
                        "Select adresid from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    adresid = dr2.GetInt32(0);
                }
                else
                {
                    cmd.CommandText =
                        "INSERT INTO ADRES(LAND,POSTCODE,WOONPLAATS,STRAATNAAM,HUISNUMMER,TOEVOEGING) VALUES(:land,:postcode,:plaats,:straatnaam,:nummer,:toe)";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    cmd.Parameters.Add("toe", toe);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =
                        "Select adresid from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    adresid = dr2.GetInt32(0);
                }
                cmd.CommandText = "INSERT INTO Gebruiker(Voornaam,Achternaam,Wachtwoord,AdresID,Geboortedatum,Email,Budget,Beheerder) VALUES(:vn,:an,:ww,:ai,:gb,:em,:bg,:bh)";
                string[] names = naam.Split(' ');
                int nameslenght = names.Length;
                cmd.Parameters.Add("vn", names[0]);
                string lastname = null;
                for (int i = 1; i < nameslenght; i++)
                {
                    lastname += names[i] + " ";
                }
                if (lastname != null) cmd.Parameters.Add("an", lastname.Trim());
                cmd.Parameters.Add("ww", wachtwoord);
                cmd.Parameters.Add("ai", adresid);
                DateTime add = Convert.ToDateTime(date);
                cmd.Parameters.Add("gb", add);
                cmd.Parameters.Add("em", email);
                cmd.Parameters.Add("bg", budget);
                cmd.Parameters.Add("bh", '0');
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }


        public List<Event> GetEvent()
        {
            List<Event> rtn = new List<Event>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    CommandText = "Select * from Event"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int eventid = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    Event add = new Event(name, eventid);
                    rtn.Add(add);
                }
                _conn.Close();
                return rtn;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
                return null;
            }
        }

        private Adress GetUserAddress(int aid)
        {
            bool intern = true;
            try
            {
                Adress add = null;

                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                    intern = false;
                }
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    CommandText = "Select * from Adres WHERE adresid=" + aid
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string country = dr.GetString(1);
                    string zip = dr.GetString(2);
                    string city = dr.GetString(3);
                    string street = dr.GetString(4);
                    int number = dr.GetInt32(5);
                    string toevoeging = null;
                    if (!dr.IsDBNull(6))
                    {
                        toevoeging = dr.GetString(6);
                    }
                    add = new Adress(street, number, city, country, zip, toevoeging);
                }
                if (!intern)
                {
                    _conn.Close();
                }
                return add;
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                if (!intern)
                {
                    _conn.Close();
                }
                return null;
            }
        }

        public void AddEvent(string straat, int nr, string toe, string plaats, string postcode, string land, string naam, DateTime begin, DateTime end)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true
                };
                if (toe != null)
                {
                    cmd.CommandText =
                        "Select count(*) from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer AND toevoeging=:toe";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    cmd.Parameters.Add("toe", toe);
                }
                else
                {
                    cmd.CommandText =
                        "Select count(*) from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                }
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int count = dr.GetInt32(0);
                int adresid;
                if (count != 0)
                {
                    cmd.CommandText =
                        "Select adresid from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    adresid = dr2.GetInt32(0);
                }
                else
                {
                    cmd.CommandText =
                        "INSERT INTO ADRES(LAND,POSTCODE,WOONPLAATS,STRAATNAAM,HUISNUMMER,TOEVOEGING) VALUES(:land,:postcode,:plaats,:straatnaam,:nummer,:toe)";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    cmd.Parameters.Add("toe", toe);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText =
                        "Select adresid from Adres WHERE land=:land AND Postcode=:postcode AND Woonplaats=:plaats AND straatnaam=:straatnaam AND huisnummer=:nummer";
                    cmd.Parameters.Add("land", land);
                    cmd.Parameters.Add("postcode", postcode);
                    cmd.Parameters.Add("plaats", plaats);
                    cmd.Parameters.Add("straatnaam", straat);
                    cmd.Parameters.Add("nummer", nr);
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    adresid = dr2.GetInt32(0);
                }
                cmd.CommandText =
                    "INSERT INTO EVENT(EVENTNAAM,BEGINDATUM,EINDDATUM,ADRESID) VALUES(:naam,:begin,:eind,:adres)";
                cmd.Parameters.Add("naam", naam);
                cmd.Parameters.Add("begin", begin);
                cmd.Parameters.Add("eind", end);
                cmd.Parameters.Add("adres", adresid);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public int HuurMateriaal(Object materiaal, User user, DateTime beginDatum, DateTime eindDatum, DateTime nuDatum , bool opgehaald)
        {
            try
            {
                int huurId = 0;

                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "select count(*) from materiaalverhuur where :begindatum between begintijd and eindtijd and materiaalid =:MatID"
                };
                cmd.Parameters.Add("begindatum", beginDatum);
                cmd.Parameters.Add("MatID", materiaal.ObjectId);
                OracleDataReader dr5 = cmd.ExecuteReader();
                dr5.Read();
                int count1 = dr5.GetInt32(0);

                if (count1 == 0)
                {
                    cmd.CommandText = "select count(*) from materiaalverhuur where :einddatum between begintijd and eindtijd and materiaalid =:MatID";
                    cmd.Parameters.Add("einddatum", eindDatum);
                    cmd.Parameters.Add("MatID", materiaal.ObjectId);
                    OracleDataReader dr6 = cmd.ExecuteReader();
                    dr6.Read();
                    int count2 = dr6.GetInt32(0);

                    if (count2 == 0)
                    {
                        cmd.CommandText = "select count(*) from materiaalverhuur where begintijd between :begindatum and :einddatum and materiaalid =:MatID";
                        cmd.Parameters.Add("begindatum", beginDatum);
                        cmd.Parameters.Add("einddatum", eindDatum);
                        cmd.Parameters.Add("MatID", materiaal.ObjectId);
                        OracleDataReader dr8 = cmd.ExecuteReader();
                        dr8.Read();
                        int count3 = dr8.GetInt32(0);
                        if (count3 == 0)
                        {
                            cmd.CommandText = "select count(*) from materiaalverhuur where eindtijd between :begindatum and :einddatum and materiaalid =:MatID";
                            cmd.Parameters.Add("begindatum", beginDatum);
                            cmd.Parameters.Add("einddatum", eindDatum);
                            cmd.Parameters.Add("MatID", materiaal.ObjectId);
                            OracleDataReader dr9 = cmd.ExecuteReader();
                            dr9.Read();
                            int count4 = dr9.GetInt32(0);
                            if (count4 == 0)
                            {
                                try
                                {
                                    cmd.CommandText = "SELECT * FROM HUUR WHERE GEBRUIKERID =:gebruiker";
                                    cmd.Parameters.Add("gebruiker", user.UserId);
                                    OracleDataReader dr = cmd.ExecuteReader();
                                    List<ObjectReservation> rents = new List<ObjectReservation>();
                                    while (dr.Read())
                                    {
                                        ObjectReservation add = new ObjectReservation(dr.GetInt32(0), dr.GetDateTime(2));
                                        rents.Add(add);
                                    }
                                    foreach (ObjectReservation res in rents)
                                    {
                                        if (res.ResTime.Hour == nuDatum.Hour || res.ResTime.Hour == (nuDatum.Hour + 1))
                                        {
                                            huurId = res.ReservationId;
                                        }
                                    }
                                }
                                catch (OracleException e)
                                {
                                    Console.WriteLine("Message: " + e.Message);
                                    _conn.Close();

                                }
                                if (huurId == 0)
                                {
                                    cmd.CommandText = "INSERT INTO HUUR(GEBRUIKERID,HUURDATUM) VALUES(:gebruiker,:datum)";
                                    cmd.Parameters.Add("gebruiker", user.UserId);
                                    cmd.Parameters.Add("datum", nuDatum);
                                    cmd.ExecuteNonQuery();
                                    try
                                    {
                                        cmd.CommandText = "SELECT * FROM HUUR WHERE GEBRUIKERID =:gebruiker";
                                        cmd.Parameters.Add("gebruiker", user.UserId);
                                        OracleDataReader dr7 = cmd.ExecuteReader();
                                        List<ObjectReservation> rents = new List<ObjectReservation>();
                                        while (dr7.Read())
                                        {
                                            ObjectReservation add = new ObjectReservation(dr7.GetInt32(0), dr7.GetDateTime(2));
                                            rents.Add(add);
                                        }
                                        foreach (ObjectReservation res in rents)
                                        {
                                            if (res.ResTime.Hour == nuDatum.Hour || res.ResTime.Hour == (nuDatum.Hour + 1))
                                            {
                                                huurId = res.ReservationId;
                                            }
                                        }
                                    }
                                    catch (OracleException e)
                                    {
                                        Console.WriteLine("Message: " + e.Message);
                                        _conn.Close();

                                    }
                                }

                                if (opgehaald)
                                {
                                    cmd.CommandText = "INSERT INTO MATERIAALVERHUUR(MATERIAALID,HUURID,BEGINTIJD,EINDTIJD,OPGEHAALD,TERUGGEBRACHT) VALUES(:MatID,:HuurID,:Begin,:Eind,:Opgehaald,:Teruggebracht)";
                                    cmd.Parameters.Add("MatID", materiaal.ObjectId);
                                    cmd.Parameters.Add("HuurID", huurId);
                                    cmd.Parameters.Add("Begin", beginDatum);
                                    cmd.Parameters.Add("Eind", eindDatum);
                                    cmd.Parameters.Add("Opgehaald", "1");
                                    cmd.Parameters.Add("Teruggebracht", "0");
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    cmd.CommandText = "INSERT INTO MATERIAALVERHUUR(MATERIAALID,HUURID,BEGINTIJD,EINDTIJD,OPGEHAALD,TERUGGEBRACHT) VALUES(:MatID,:HuurID,:Begin,:Eind,:Opgehaald,:Teruggebracht)";
                                    cmd.Parameters.Add("MatID", materiaal.ObjectId);
                                    cmd.Parameters.Add("HuurID", huurId);
                                    cmd.Parameters.Add("Begin", beginDatum);
                                    cmd.Parameters.Add("Eind", eindDatum);
                                    cmd.Parameters.Add("Opgehaald", "0");
                                    cmd.Parameters.Add("Teruggebracht", "0");
                                    cmd.ExecuteNonQuery();
                                }

                                _conn.Close();
                            }
                            else
                            {
                                _conn.Close();
                                return 2;
                            }
                        }
                        else
                        {
                            _conn.Close();
                            return 1;
                        }
                    }
                    else
                    {
                        _conn.Close();
                        return 2;
                    }
                }
                else
                {
                    _conn.Close();
                    return 1;
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
            _conn.Close();
            return 3;
        }

        public void AddGroup(IEnumerable<User> groupUsers, string text)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "INSERT INTO GROEP(Groepsnaam) VALUES(:groepsnaam)"
                };
                cmd.Parameters.Add("groepsnaam", text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT GROEPID FROM GROEP WHERE GROEPSNAAM =:groepsnaam";
                cmd.Parameters.Add("groepsnaam", text);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int groupid = dr.GetInt32(0);
                foreach (User usr in groupUsers)
                {
                    cmd.CommandText = "INSERT INTO GEBRUIKERGROEP(GROEPID, GEBRUIKERID) VALUES(:groepid,:gebruikerid)";
                    cmd.Parameters.Add("groepid", groupid);
                    cmd.Parameters.Add("gebruikerid", usr.UserId);
                    cmd.ExecuteNonQuery();
                }
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public List<Group> GetEmptyGroups()
        {
            List<Group> empty = new List<Group>();
            _conn.Open();
            OracleCommand cmd = new OracleCommand
            {
                Connection = _conn,
                BindByName = true,
                CommandText = "SELECT GROEPID FROM GROEP WHERE PLAATSNR IS NULL"
            };
            OracleDataReader dr = cmd.ExecuteReader();
            List<int> groups = new List<int>();
            while (dr.Read())
            {
                groups.Add(dr.GetInt32(0));
            }
            if (groups.Count > 0)
            {
                foreach (int i in groups)
                {
                    List<User> usr = new List<User>();
                    cmd.CommandText = "SELECT GEBRUIKERID FROM GEBRUIKERGROEP WHERE GROEPID='" + i + "'";
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        int uid = dr2.GetInt32(0);
                        usr.Add(GetUser(uid, true));
                    }
                    cmd.CommandText = "SELECT GROEPSNAAM FROM GROEP WHERE GROEPID='" + i + "'";
                    OracleDataReader dr3 = cmd.ExecuteReader();
                    dr3.Read();
                    Group add = new Group(dr3.GetString(0), i, usr);
                    empty.Add(add);
                    dr3.Dispose();
                    dr2.Dispose();
                }
            }
            _conn.Close();
            return empty;
        }

        public List<Location> GetFreeLocations(int count)
        {
            List<Location> freeLocations = new List<Location>();

            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText =
                        "SELECT * FROM VERBLIJFPLAATS WHERE ACCOMODATIEID IN(SELECT ACCOMODATIEID FROM ACCOMODATIE WHERE EVENTID = '1') AND PLAATSNR NOT IN(SELECT PLAATSNR FROM GROEP WHERE PLAATSNR IS NOT NULL) AND MAXAANTALPERSONEN >= :personen"
                };
                cmd.Parameters.Add("personen", count);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string desc = dr.GetString(3);
                    int locid = dr.GetInt32(0);
                    int spaces = dr.GetInt32(2);
                    Location add = new Location(desc, locid, spaces);
                    freeLocations.Add(add);
                }
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
            return freeLocations;
        }

        public void ReserveLocation(Group searchgroup, Location reserve)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "UPDATE GROEP SET PLAATSNR = :plaats WHERE GROEPID =:groep"
                };
                cmd.Parameters.Add("plaats", reserve.LocationId);
                cmd.Parameters.Add("groep", searchgroup.GroupId);
                cmd.ExecuteNonQuery();
                _conn.Close();

            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public List<ObjectReservation> GetReserved()
        {
            List<ObjectReservation> ret = new List<ObjectReservation>();
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "SELECT * FROM MATERIAALVERHUUR WHERE OPGEHAALD='0' AND TERUGGEBRACHT ='0'"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int resid = dr.GetInt32(0);
                    DateTime start = dr.GetDateTime(3);
                    DateTime end = dr.GetDateTime(4);
                    int objId = dr.GetInt32(1);
                    cmd.CommandText = "SELECT * FROM MATERIAAL WHERE MATERIAALID ='" + objId + "'";
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    Object obj = new Object(dr2.GetInt32(0), dr2.GetString(1), dr2.GetString(2), dr2.GetInt32(3),
                        dr2.GetDecimal(4));
                    cmd.CommandText = "SELECT GEBRUIKERID FROM HUUR WHERE HUURID='" + dr.GetInt32(2) + "'";
                    OracleDataReader dr3 = cmd.ExecuteReader();
                    dr3.Read();
                    User usr = GetUser(dr3.GetInt32(0), true);
                    ObjectReservation add = new ObjectReservation(resid, usr, start, end, obj);
                    ret.Add(add);
                }
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: "+e.Message);
                _conn.Close();
            }
            return ret;
        }

        public List<ObjectReservation> GetBorrowed()
        {
            List<ObjectReservation> ret = new List<ObjectReservation>();
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "SELECT * FROM MATERIAALVERHUUR WHERE OPGEHAALD='1' AND TERUGGEBRACHT ='0'"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int resid = dr.GetInt32(0);
                    DateTime start = dr.GetDateTime(3);
                    DateTime end = dr.GetDateTime(4);
                    int objId = dr.GetInt32(1);
                    cmd.CommandText = "SELECT * FROM MATERIAAL WHERE MATERIAALID ='" + objId + "'";
                    OracleDataReader dr2 = cmd.ExecuteReader();
                    dr2.Read();
                    Object obj = new Object(dr2.GetInt32(0), dr2.GetString(1), dr2.GetString(2), dr2.GetInt32(3),
                        dr2.GetDecimal(4));
                    cmd.CommandText = "SELECT GEBRUIKERID FROM HUUR WHERE HUURID='" + dr.GetInt32(2) + "'";
                    OracleDataReader dr3 = cmd.ExecuteReader();
                    dr3.Read();
                    User usr = GetUser(dr3.GetInt32(0), true);
                    ObjectReservation add = new ObjectReservation(resid, usr, start, end, obj);
                    ret.Add(add);
                }
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
            return ret;
        }

        public void BorrowObject(ObjectReservation res)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "UPDATE MATERIAALVERHUUR SET OPGEHAALD='1' WHERE MATERIAALVERHUURID='" +
                                  res.ReservationId + "'"
                };
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }

        public void TakeBackObject(ObjectReservation res)
        {
            try
            {
                _conn.Open();
                OracleCommand cmd = new OracleCommand
                {
                    Connection = _conn,
                    BindByName = true,
                    CommandText = "UPDATE MATERIAALVERHUUR SET TERUGGEBRACHT='1' WHERE MATERIAALVERHUURID='" +
                                  res.ReservationId + "'"
                };
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                _conn.Close();
            }
        }
    }
}