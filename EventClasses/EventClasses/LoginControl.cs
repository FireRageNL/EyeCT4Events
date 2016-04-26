namespace EventClasses
{
    public class LoginControl
    {
        private readonly DbAdmin _db = new DbAdmin();
        public Login ValidateUser(string email, string password)
        {
            string check = _db.CheckLogin(email);
            if (check != null)
            {
                string[] split = check.Split(',');
                int val;
                if (int.TryParse(split[1], out val))
                {
                    if (password == split[0])
                    {
                        User usr = _db.GetUser(email);
                        Login log = new Login(val, usr);
                        return log;
                    }
                }
            }
            return null;
        }
    }
}
