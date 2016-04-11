using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toegangscontrole
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnInloggen_Click(object sender, EventArgs e)
        {
            string email = TbEmail.Text;
            string password = TbPassword.Text;
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vul alle velden in a.u.b.");
            }
            else
            {
                EventClasses.Login user = new EventClasses.Login();
                bool success = user.ValidateUser(email, password);
                if (success)
                {
                    int alvl = user.AccessLevel;
                    Toegangscontrole check = new Toegangscontrole();
                    this.Hide();
                    check.Show();
                }
                else
                {
                    MessageBox.Show("Verkeerde gebruikersnaam en/of wachtwoord ingevuld!");
                    TbPassword.Text = "";
                }
            }
        }
    }
}
