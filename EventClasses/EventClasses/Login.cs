using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Login
    {
        public int AccessLevel { get; private set; }
        
        public bool LoggedIn { get; private set; }


        public bool ValidateUser(string email, string password)
        {
            return false;
        }
    }
}
