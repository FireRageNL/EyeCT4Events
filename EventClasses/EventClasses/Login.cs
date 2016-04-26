namespace EventClasses
{
    public class Login
    {
        public int AccessLevel { get; private set; }
        
        public bool LoggedIn { get; private set; }

        public User User { get; private set; }

        public Login(int level, bool login, User usr)
        {
            AccessLevel = level;
            LoggedIn = login;
            User = usr;
        }
    }
}
