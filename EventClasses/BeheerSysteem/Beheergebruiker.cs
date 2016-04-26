using System;
using System.Collections.Generic;
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
            List<User> User = gc.BeheerUser();
            listBox1.DataSource = User;
        }

        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je dit object wilt verwijderen?", "Waarschuwing!",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                User DeleteUser = (User) listBox1.SelectedItem;
                gc.DeleteUser(DeleteUser);
            }
            List<User> User= gc.BeheerUser();
            listBox1.DataSource = User;
        }

        private void BtnWijzigen_Click(object sender, EventArgs e)
        {
            User UpdateUser = (User)listBox1.SelectedItem;
            UserDialog dia = new UserDialog(val, false, UpdateUser);
            dia.ShowDialog();
            List<User> BeheerUser= gc.BeheerUser();
            listBox1.DataSource = BeheerUser;
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            UserDialog dia = new UserDialog(val, true);
            dia.ShowDialog();
            List<User> BeheerUser = gc.BeheerUser();
          listBox1.DataSource = BeheerUser;
        }
    }
}
