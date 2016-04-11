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
        static DAL Start = new DAL();
        DBAdmin DatabaseAdmin = new DBAdmin(Start);

        public DBAdmin(DAL dal)
        {

            Dal = dal;
        }

        public DataSet SendDbCommand(string command)
        {
            DataSet returnval = Dal.ExecuteDbCommand(command);
            return returnval;
        }

        public void SendDbCommandvoid(string command)
        {
            Dal.ExecuteDbCommand(command);
        }

        public CheckIn CheckIn(int rfidtag)
        {

        }

        //Checkin
        public string checkname()
        {
            //Naam bezoeker checken
            DataTable dtnaam = new DataTable();
            string dbcommandnaam = "Select g.Naam from gebruiker g inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet naam = DatabaseAdmin.SendDbCommand(dbcommandnaam);
            dtnaam = naam.Tables[0];
            String Naam = dtnaam.Rows[0][0].ToString();
            return Naam;
        }

        public int checkaanwezig()
        {
            //Aanwezigheid Checken/Aanpassen
            DataTable dtaanwezig = new DataTable();
            string dbcommandaanwezig = "Select a.Aanwezigheid from Aanwezig a inner join gebruiker g on a.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet aanwezig = DatabaseAdmin.SendDbCommand(dbcommandaanwezig);
            dtaanwezig = aanwezig.Tables[0];
            int Aanwezig = Convert.ToInt32(dtaanwezig.Rows[0][0].ToString());

            if (Aanwezig== 1)
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
            return Aanwezig;
        }

        public int checkbetaald()
        {
            //Betaaldstatus checken
            DataTable dtbetaald = new DataTable();
            string dbcommandbetaald = "Select t.Betaald from Toegangsreservering t inner join gebruiker g on t.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet betaald = DatabaseAdmin.SendDbCommand(dbcommandbetaald);
            dtbetaald = betaald.Tables[0];
            int payment = Convert.ToInt32(dtbetaald.Rows[0][0].ToString());
            return payment;
        }
    }
}

