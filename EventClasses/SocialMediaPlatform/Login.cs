﻿using System;
using System.Windows.Forms;
using EventClasses;

namespace SocialMediaPlatform
{
    public partial class Login : Form
    {
        readonly LoginControl _lg = new LoginControl();

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
                EventClasses.Login val = _lg.ValidateUser(email, password);
                if (val != null)
                {
                    PostOverview form = new PostOverview(val);
                    Hide();
                    form.Closed += (sender1, args) =>
                    {
                        Close();
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
