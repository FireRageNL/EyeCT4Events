using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class UserDialog : Form
    {
        private User updateUser;
        private bool v;
        private EventClasses.Login val;

        public UserDialog(EventClasses.Login val, bool v)
        {
            this.val = val;
            this.v = v;
        }

        public UserDialog(EventClasses.Login val, bool v, User updateUser)
        {
            this.val = val;
            this.v = v;
            this.updateUser = updateUser;
        }
    }
}
