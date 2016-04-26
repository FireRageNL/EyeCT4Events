using System;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class Login : Form
    {
        LoginControl lg = new LoginControl();

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
                EventClasses.Login val = lg.ValidateUser(email, password);
                if (val != null)
                {
                    if (val.AccessLevel > 0)
                    {
                        AdminCP form1 = new AdminCP(val);
                        form1.Show();
                        this.Hide();
                        form1.Closed += (sender1, args) => { this.Close(); };
                    }

                    else
                    {
                        MessageBox.Show("Niet genoeg rechten om in te loggen!");
                        TbPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Verkeerd wachtwoord/email in gevoerd!");
                    TbPassword.Clear();
                }
            }
        }
    }
}
