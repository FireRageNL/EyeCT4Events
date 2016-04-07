using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Login
    {
        static DAL Start = new DAL();
        DBAdmin DatabaseAdmin = new DBAdmin(Start);
        public int AccessLevel { get; private set; }
        
        public bool LoggedIn { get; private set; }

        public bool ValidateUser(string email, string password)
        {
            DataTable dt = new DataTable();
            string dbcommand = "SELECT Wachtwoord, Beheerder FROM Gebruiker WHERE E-mail=" + email;
            DataSet stuff = DatabaseAdmin.SendDbCommand(dbcommand);
            if (stuff != null)
            {
                dt = stuff.Tables[0];
                string dbpass = dt.Rows[0][0].ToString();
                int level = Convert.ToInt32(dt.Rows[0][1].ToString());
                if (dbpass == password)
                {
                    AccessLevel = level;
                    LoggedIn = true;
                    return true;
                }
            }
            return false;
        }
    }
}
