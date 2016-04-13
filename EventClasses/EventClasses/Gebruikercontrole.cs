using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Gebruikercontrole
    {
        private DBAdmin db = new DBAdmin();

        public List<User> Geenachternaam(string email, string datum)
        {
            return db.Geenachternaam(email, datum);
        }

        public List<User> Geenemail(string achternaam, string datum)
        {
            return db.Geenemail(achternaam, datum);
        }
        public List<User> Geendatum(string achternaam, string email)
        {
            return db.Geendatum(achternaam, email);
        }

        public List<User> Alleenachternaam(string achternaam)
        {
            return db.Alleenachternaam(achternaam);
        }
        public List<User> Alleendatum(string datum)
        {
            return db.Alleendatum(datum);
        }

        public List<User> Alleenemail(string email)
        {
            return db.Alleenemail(email);
        }
        public List<User> Alles(string email, string achternaam, string datum)
        {
            return db.Alles(email, achternaam, datum);
        }
        public List<User> BeheerUser()
        {
            return db.BeheerUser();
        }
        public void DeleteUser(User DeleteUser)
        {
            db.DeleteUser(DeleteUser);
        }

        public void UpdateUser(User user, string password = null)
        {
            db.UpdateUser(user,password);
        }

        public void AddUser(string Naam, string Wachtwoord, string Date , string Email, decimal Budget, string straat, int nr, string toe, string plaats, string postcode, string land)
        {
           db.AddUser(Naam,Wachtwoord,Date,Email,Budget,straat,nr,toe,plaats,postcode,land);
        }

    }
}


