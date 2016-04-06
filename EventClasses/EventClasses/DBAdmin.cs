using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class DBAdmin
    {
        public DAL Dal { get; private set; }

        public DBAdmin(DAL dal)
        {
            Dal = dal;
        }

        public bool SendDbCommand(string command)
        {
            bool test = Dal.ExecuteDbCommand(command);
            return test;
        }
    }
}
