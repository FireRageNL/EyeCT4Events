using System.Collections.Generic;

namespace EventClasses
{
    public class Gebruikercontrole
    {
        private readonly DbAdmin _db = new DbAdmin();

        public List<User> Geenachternaam(string email, string datum)
        {
            return _db.Geenachternaam(email, datum);
        }

        public List<User> Geenemail(string achternaam, string datum)
        {
            return _db.Geenemail(achternaam, datum);
        }
        public List<User> Geendatum(string achternaam, string email)
        {
            return _db.Geendatum(achternaam, email);
        }

        public List<User> Alleenachternaam(string achternaam)
        {
            return _db.Alleenachternaam(achternaam);
        }
        public List<User> Alleendatum(string datum)
        {
            return _db.Alleendatum(datum);
        }

        public List<User> Alleenemail(string email)
        {
            return _db.Alleenemail(email);
        }
        public List<User> Alles(string email, string achternaam, string datum)
        {
            return _db.Alles(email, achternaam, datum);
        }
        public List<User> BeheerUser()
        {
            return _db.BeheerUser();
        }
        public void DeleteUser(User deleteUser)
        {
            _db.DeleteUser(deleteUser);
        }

        public void UpdateUser(User user, string password = null)
        {
            _db.UpdateUser(user,password);
        }

        public void AddUser(string naam, string wachtwoord, string date , string email, decimal budget, string straat, int nr, string toe, string plaats, string postcode, string land)
        {
           _db.AddUser(naam,wachtwoord,date,email,budget,straat,nr,toe,plaats,postcode,land);
        }

    }
}


