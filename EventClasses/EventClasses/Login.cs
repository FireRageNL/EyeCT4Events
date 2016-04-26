namespace EventClasses
{
    public class Login
    {
        public int AccessLevel { get; private set; }

        public User User { get; private set; }

        public Login(int level, User usr)
        {
            AccessLevel = level;
            User = usr;
        }
    }
}
