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
                    if (val.AccessLevel == 1)
                    {
                        Materiaalbeheer form1 = new Materiaalbeheer(val);
                        form1.Show();
                        this.Hide();
                    }
                    if (val.AccessLevel == 2)
                    {
                        FormGebruikersBeheer form = new FormGebruikersBeheer(val);
                        form.Show();
                        this.Hide();
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
