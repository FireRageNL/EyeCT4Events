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
    public partial class Beheergroep : Form
    {
        private EventClasses.Login Val;
        private GroepControl gc = new GroepControl();
        private List<User> users = new List<User>();
        public Beheergroep(EventClasses.Login val)
        {   
            InitializeComponent();
            Val = val;
            users = gc.GetUsers();
            listBox1.DataSource = users;
            listBox1.DisplayMember = "GroupName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User add = (User) listBox1.SelectedItem;
            listBox2.Items.Add(add);
            users.Remove(add);
            listBox1.DataSource = null;
            listBox1.DataSource = users;
            listBox1.DisplayMember = "GroupName";
            listBox2.DisplayMember = "GroupName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbGroep.Text)) return;
            List<User> groupUsers = listBox2.Items.OfType<User>().ToList();
            gc.AddGroup(groupUsers,tbGroep.Text);
            users = gc.GetUsers();
            listBox1.DataSource = null;
            listBox1.DataSource = users;
            listBox1.DisplayMember = "GroupName";
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<User> search = new List<User>();
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {  
                foreach (User usr in users)
                {
                    if (usr.Name.Contains(textBox1.Text))
                    {
                        search.Add(usr);
                    }
                }
            }
            else if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                foreach (User usr in users)
                {
                    if (usr.Emailadres.Contains(textBox2.Text))
                    {
                        search.Add(usr);
                    }
                }
            }
            else
            {
                search = users;
            }
            listBox1.DataSource = null;
            listBox1.DataSource = search;
            listBox1.DisplayMember = "GroupName";
        }
    }
}
