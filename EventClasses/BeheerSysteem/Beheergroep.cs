using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class Beheergroep : Form
    {
        private readonly GroepControl _gc = new GroepControl();
        private List<User> _users;
        public Beheergroep()
        {   
            InitializeComponent();
            _users = _gc.GetUsers();
            listBox1.DataSource = _users;
            listBox1.DisplayMember = "GroupName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User add = (User) listBox1.SelectedItem;
            listBox2.Items.Add(add);
            _users.Remove(add);
            listBox1.DataSource = null;
            listBox1.DataSource = _users;
            listBox1.DisplayMember = "GroupName";
            listBox2.DisplayMember = "GroupName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbGroep.Text)) return;
            List<User> groupUsers = listBox2.Items.OfType<User>().ToList();
            _gc.AddGroup(groupUsers,tbGroep.Text);
            _users = _gc.GetUsers();
            listBox1.DataSource = null;
            listBox1.DataSource = _users;
            listBox1.DisplayMember = "GroupName";
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<User> search = new List<User>();
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {  
                foreach (User usr in _users)
                {
                    if (usr.Name.Contains(textBox1.Text))
                    {
                        search.Add(usr);
                    }
                }
            }
            else if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                foreach (User usr in _users)
                {
                    if (usr.Emailadres.Contains(textBox2.Text))
                    {
                        search.Add(usr);
                    }
                }
            }
            else
            {
                search = _users;
            }
            listBox1.DataSource = null;
            listBox1.DataSource = search;
            listBox1.DisplayMember = "GroupName";
        }
    }
}
