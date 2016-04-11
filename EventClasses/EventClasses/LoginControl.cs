﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class LoginControl
    {
        private DBAdmin db = new DBAdmin();
        public Login ValidateUser(string email, string password)
        {
            string check = db.CheckLogin(email);
            if (check != null)
            {
                string[] split = check.Split(',');
                int val;
                if (int.TryParse(split[1], out val))
                {
                    if (password == split[0])
                    {
                        Login log = new Login(val, true);
                        return log;
                    }
                }
            }
            return null;
        }
    }
}
