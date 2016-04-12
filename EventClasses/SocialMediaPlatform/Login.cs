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

namespace SocialMediaPlatform
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
                    PostOverview form = new PostOverview(val);
                    this.Hide();
                    form.Closed += (sender1, args) =>
                    {
                        this.Close();
                    };
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Verkeerde gebruikersnaam/wachtwoord ingevoerd!");
                    TbPassword.Clear();
                }
            }
        }
    }
}
