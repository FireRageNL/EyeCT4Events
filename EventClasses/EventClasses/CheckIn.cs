using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EventClasses
{
    public class CheckIn
    {
        static DAL Start = new DAL();
        DBAdmin DatabaseAdmin = new DBAdmin(Start);
        public RFID RfidTag { get; private set; }
        public int Aanwezig { get; private set; }
        public string Naam { get; private set; }
        public Boolean Betaald { get; private set; }

        public CheckIn(int tag)
        {
            //Naam bezoeker checken
            DataTable dtnaam = new DataTable();
            string dbcommandnaam = "Select g.Naam from gebruiker g inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet naam = DatabaseAdmin.SendDbCommand(dbcommandnaam);
            dtnaam = naam.Tables[0];
            Naam = dtnaam.Rows[0][0].ToString();


            //Aanwezigheid Checken/Aanpassen
            DataTable dtaanwezig = new DataTable();
            string dbcommandaanwezig = "Select a.Aanwezigheid from Aanwezig a inner join gebruiker g on a.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet aanwezig = DatabaseAdmin.SendDbCommand(dbcommandaanwezig);
            dtaanwezig = aanwezig.Tables[0];
            Aanwezig = Convert.ToInt32(dtaanwezig.Rows[0][0].ToString());
            ChangeStatus();



            //Betaaldstatus checken
            DataTable dtbetaald = new DataTable();
            string dbcommandbetaald = "Select t.Betaald from Toegangsreservering t inner join gebruiker g on t.gebruikerid = g.gebruikerid inner join bandje b on g.gebruikerid = b.gebruikerid where b.RIFDcode = RFID";
            DataSet betaald = DatabaseAdmin.SendDbCommand(dbcommandbetaald);
            dtbetaald = betaald.Tables[0];
            int payment = Convert.ToInt32(dtbetaald.Rows[0][0].ToString());

            if (payment == 0)
            {
                Betaald = false;
            }
            else
            {
                Betaald = true;
            }
        }

        public void ChangeStatus()
        {
            if (this.Aanwezig == 1)
            {
                this.Aanwezig = 0;
                string dbchangestatus = "update Aanwezigheid from Aanwezig where Aanwezigheid = 0";
                DatabaseAdmin.SendDbCommandvoid(dbchangestatus);
            }
            else if (this.Aanwezig == 0)
            {
                this.Aanwezig = 1;
                string dbchangestatus = "update Aanwezigheid from Aanwezig where Aanwezigheid = 1";
                DatabaseAdmin.SendDbCommandvoid(dbchangestatus);
            }


        }
    }
}
