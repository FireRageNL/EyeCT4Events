namespace EventClasses
{
    public class User
    {
        public int UserId { get; }

        public string Name { get; private set; }

        public Adress Adress { get; private set; }

        public string Emailadres { get; private set; }

        public string Date { get; private set; }

        public decimal Budget { get; private set; }

        public User (int id, string naam , string email , string datum)
        {
            UserId = id;
            Name = naam;
            Emailadres = email;
            Date = datum;
        }

        public User(int uid, string uname, string uemail)
        {
            UserId = uid;
            Name = uname;
            Emailadres = uemail;
        }

        public User(int id, string naam, string email, string datum, decimal budget, Adress uadres)
        {
            UserId = id;
            Name = naam;
            Emailadres = email;
            Date = datum;
            Budget = budget;
            Adress = uadres;
        }

        public override string ToString()
        {
            return "   ID: " + UserId + "   Naam: " + Name + "   Email: " + Emailadres + "   Geboortedatum: " + Date;
        }

        // ReSharper disable once UnusedMember.Global used in winform
        public string GroupName => Name + " " + Emailadres;

        public void Update(string naam,string email, string datum, decimal budget)
        {
            Name = naam;
            Emailadres = email;
            Date = datum;
            Budget = budget;
        }
    }
}
