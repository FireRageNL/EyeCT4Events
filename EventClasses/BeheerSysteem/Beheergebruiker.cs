using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class Beheergebruiker : Form
    {
        private readonly Gebruikercontrole _gc = new Gebruikercontrole();
        public Beheergebruiker()
        {
            InitializeComponent();
            List<User> user = _gc.BeheerUser();
            listBox1.DataSource = user;
        }

        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je dit object wilt verwijderen?", "Waarschuwing!",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                User deleteUser = (User) listBox1.SelectedItem;
                _gc.DeleteUser(deleteUser);
            }
            List<User> user= _gc.BeheerUser();
            listBox1.DataSource = user;
        }

        private void BtnWijzigen_Click(object sender, EventArgs e)
        {
            User updateUser = (User)listBox1.SelectedItem;
            UserDialog dia = new UserDialog(false, updateUser);
            dia.ShowDialog();
            List<User> beheerUser= _gc.BeheerUser();
            listBox1.DataSource = beheerUser;
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            UserDialog dia = new UserDialog(true);
            dia.ShowDialog();
            List<User> beheerUser = _gc.BeheerUser();
          listBox1.DataSource = beheerUser;
        }
    }
}
