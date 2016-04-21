using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Verhuurcontrole
    {
        private DBAdmin db = new DBAdmin();

        //public void Huur(EventClasses.Object Materiaal , EventClasses.User User , DateTime BeginDatum , DateTime EindDatum)
        //{
        //    db.HuurMateriaal(Materiaal, User, BeginDatum, EindDatum);
        //}


        //public void HuurMateriaal(EventClasses.Object Materiaal, EventClasses.User User, DateTime BeginDatum, DateTime EindDatum , DateTime NuDatum)
        //{
        //    try
        //    {
        //        conn.Open();
        //        OracleCommand cmd = new OracleCommand();
        //        cmd.Connection = conn;
        //        cmd.BindByName = true;
        //        cmd.CommandText = "INSERT INTO HUUR(GEBRUIKERID,HUURDATUM) VALUES(:gebruiker,:datum)";
        //        cmd.Parameters.Add("gebruiker",User.UserID);
        //        cmd.Parameters.Add("datum", NuDatum);


        //        cmd.CommandText = "INSERT INTO HUUR(GEBRUIKERID,HUURDATUM) VALUES(:gebruiker,:datum)";
        //        cmd.Parameters.Add("gebruiker", User.UserID);
        //        cmd.Parameters.Add("datum", NuDatum);
        //        cmd.ExecuteNonQuery();
        //        conn.Close();

        //        OracleDataReader dr = cmd.ExecuteReader();
        //        dr.Read();
        //    }
        //    catch (OracleException e)
        //    {
        //        Console.WriteLine("Message: " + e.Message);
        //        conn.Close();
        //    }
        //}


    }
}
