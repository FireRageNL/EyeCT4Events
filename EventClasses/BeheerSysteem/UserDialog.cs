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
    public partial class UserDialog : Form
    {
        private User updateUser;
        private bool v;
        private EventClasses.Login val;
        private Gebruikercontrole gc = new Gebruikercontrole();

        public UserDialog(EventClasses.Login val, bool v)
        {
            InitializeComponent();
            this.val = val;
            this.v = v;
        }

        public UserDialog(EventClasses.Login val, bool v, User upd)
        {
            InitializeComponent();
            this.val = val;
            this.v = v;
            updateUser = upd;
            tbBudget.Text = Convert.ToString(updateUser.Budget);
            tbLand.Text = updateUser.Adress.Country;
            tbEmail.Text = updateUser.Emailadres;
            tbNaam.Text = updateUser.Name;
            tbNr.Text = Convert.ToString(updateUser.Adress.Number);
            tbPlaats.Text = updateUser.Adress.City;
            tbPost.Text = updateUser.Adress.Zipcode;
            tbStraat.Text = updateUser.Adress.Street;
            tbToev.Text = updateUser.Adress.Addition;
            IFormatProvider culture = new System.Globalization.CultureInfo("en-US", true);
            dateTimePicker1.Value = Convert.ToDateTime(updateUser.Date,culture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLand.Text) && !string.IsNullOrWhiteSpace(tbNaam.Text) &&
                !string.IsNullOrWhiteSpace(tbNr.Text) && !string.IsNullOrWhiteSpace(tbPlaats.Text)
                && !string.IsNullOrWhiteSpace(tbPost.Text) && !string.IsNullOrWhiteSpace(tbStraat.Text)
                && !string.IsNullOrWhiteSpace(tbBudget.Text) && !string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                string land = tbLand.Text;
                string naam = tbNaam.Text;
                int nr;
                if (!int.TryParse(tbNr.Text, out nr))
                {
                    MessageBox.Show("Voer alleen nummers in a.u.b.");
                    nr = 0;
                }
                string plaats = tbPlaats.Text;
                string postcode = tbPost.Text;
                string straat = tbStraat.Text;
                string toe = null;
                if (!string.IsNullOrWhiteSpace(tbToev.Text))
                {
                    toe = tbToev.Text;
                }
                string email = tbEmail.Text;
                decimal budget;
                bool dcok = true;
                if (!decimal.TryParse(tbBudget.Text, out budget))
                {
                    MessageBox.Show("Voer alleen nummers in a.u.b.");
                    dcok = false;
                }
                bool pwok = true;
                if (v && string.IsNullOrWhiteSpace(tbWachtwoord.Text))
                {
                    MessageBox.Show("Vul een wachtwoord in!");
                    pwok = false;
                }
                string[] naamverify = naam.Split(' ');
                if (naamverify.Length > 1)
                {
                    if (nr != 0 && dcok && pwok)
                    {
                        if (v)
                        {
                            gc.AddUser(naam, tbWachtwoord.Text, Convert.ToString(dateTimePicker1.Value.Date), email,
                                budget, straat, nr, toe, plaats, postcode, land);
                        }
                        else
                        {
                            updateUser.Adress.Update(straat, nr, plaats, land, postcode, toe);
                            updateUser.Update(naam, email, Convert.ToString(dateTimePicker1.Value.Date), budget);
                            if (!string.IsNullOrWhiteSpace(tbWachtwoord.Text))
                            {
                                gc.UpdateUser(updateUser, tbWachtwoord.Text);
                            }
                            else
                            {
                                gc.UpdateUser(updateUser);
                            }
                        }
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Vul de volledige naam in!");
                }
            }
        }
    }
}