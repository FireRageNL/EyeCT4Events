using System;
using System.Globalization;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class UserDialog : Form
    {
        private readonly User _updateUser;
        private readonly bool _v;
        private readonly Gebruikercontrole _gc = new Gebruikercontrole();

        public UserDialog(bool v)
        {
            InitializeComponent();
            _v = v;
        }

        public UserDialog(bool v, User upd)
        {
            InitializeComponent();
            _v = v;
            _updateUser = upd;
            tbBudget.Text = Convert.ToString(_updateUser.Budget, CultureInfo.CurrentCulture);
            tbLand.Text = _updateUser.Adress.Country;
            tbEmail.Text = _updateUser.Emailadres;
            tbNaam.Text = _updateUser.Name;
            tbNr.Text = Convert.ToString(_updateUser.Adress.Number);
            tbPlaats.Text = _updateUser.Adress.City;
            tbPost.Text = _updateUser.Adress.Zipcode;
            tbStraat.Text = _updateUser.Adress.Street;
            tbToev.Text = _updateUser.Adress.Addition;
            IFormatProvider culture = new CultureInfo("en-US", true);
            dateTimePicker1.Value = Convert.ToDateTime(_updateUser.Date,culture);
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
                if (_v && string.IsNullOrWhiteSpace(tbWachtwoord.Text))
                {
                    MessageBox.Show("Vul een wachtwoord in!");
                    pwok = false;
                }
                string[] naamverify = naam.Split(' ');
                if (naamverify.Length > 1)
                {
                    if (nr != 0 && dcok && pwok)
                    {
                        if (_v)
                        {
                            _gc.AddUser(naam, tbWachtwoord.Text, Convert.ToString(dateTimePicker1.Value.Date, CultureInfo.CurrentCulture), email,
                                budget, straat, nr, toe, plaats, postcode, land);
                        }
                        else
                        {
                            _updateUser.Adress.Update(straat, nr, plaats, land, postcode, toe);
                            _updateUser.Update(naam, email, Convert.ToString(dateTimePicker1.Value.Date, CultureInfo.CurrentCulture), budget);
                            if (!string.IsNullOrWhiteSpace(tbWachtwoord.Text))
                            {
                                _gc.UpdateUser(_updateUser, tbWachtwoord.Text);
                            }
                            else
                            {
                                _gc.UpdateUser(_updateUser);
                            }
                        }
                    }
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Vul de volledige naam in!");
                }
            }
        }
    }
}