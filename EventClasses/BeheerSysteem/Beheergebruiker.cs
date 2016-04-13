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
    public partial class Beheergebruiker : Form
    {
        private EventClasses.Login val;
        private Gebruikercontrole gc = new Gebruikercontrole();
        public Beheergebruiker(EventClasses.Login val)
        {
            InitializeComponent();
            this.val = val;
            List<EventClasses.User> User = gc.BeheerUser();
            listBox1.DataSource = User;
        }

        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            EventClasses.User DeleteUser = (EventClasses.User)listBox1.SelectedItem;
            gc.DeleteUser(DeleteUser);

            List<EventClasses.User> User= gc.BeheerUser();
            listBox1.DataSource = User;
        }
    }
}
