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
                success = true;
                if (success)
                {
                    int alvl = user.AccessLevel;
                    alvl = 2;
                    if (alvl == 1)
                    {
                        FormGebruikersBeheer form = new FormGebruikersBeheer();
                        form.Show();
                        this.Hide();
                    }
                    else if (alvl == 2)
                    {
                        Materiaalbeheer form1 = new Materiaalbeheer();
                        form1.Show();
                        this.Hide();
                    }
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
