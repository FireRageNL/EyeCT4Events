﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class SocialControl
    {
        private DBAdmin db = new DBAdmin();

        public List<string> GetPosts()
        {
            return db.GetPosts();
        }
    }
}
