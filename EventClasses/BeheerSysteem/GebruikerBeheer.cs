using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class FormGebruikersBeheer : Form
    {
        private readonly Gebruikercontrole _mc = new Gebruikercontrole();

        public FormGebruikersBeheer()
        {
            InitializeComponent();
        }
        private void BtnZoeken_Click(object sender, EventArgs e)
        {
            string achternaam = TbAchternaam.Text;
            string email = TbEmail.Text;
            string datum = TbDatum.Text;


            if (TbAchternaam.Text == "" && TbEmail.Text != "" && TbDatum.Text != "")
            {
                List<User> geenachternaam = _mc.Geenachternaam(email, datum);
                dataGridView1.DataSource = geenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<User> geenachternaam = _mc.Geenemail(achternaam, datum);
                dataGridView1.DataSource = geenachternaam;
            }

            else if (TbDatum.Text == "" && TbEmail.Text != "" && TbAchternaam.Text != "")
            {
                List<User> geendatum = _mc.Geendatum(achternaam, email);
                dataGridView1.DataSource = geendatum;
            }

            else if (TbEmail.Text == "" && TbDatum.Text == "" && TbAchternaam.Text != "")
            {
                List<User> alleenachternaam = _mc.Alleenachternaam(achternaam);
                dataGridView1.DataSource = alleenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text == "")
            {
                List<User> alleendatum = _mc.Alleendatum(datum);
                dataGridView1.DataSource = alleendatum;
            }

            else if (TbEmail.Text != "" && TbDatum.Text == "" && TbAchternaam.Text == "")
            {
                List<User> alleenachternaam = _mc.Alleenemail(email);
                dataGridView1.DataSource = alleenachternaam;
            }

            else if (TbEmail.Text != "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<User> alles = _mc.Alles(achternaam, email, datum);
                dataGridView1.DataSource = alles;
            }
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TbAchternaam.Text = "";
            TbEmail.Text = "";
            TbDatum.Text = "";
            dataGridView1.DataSource = null;
        }

        private void BtnBeheer_Click(object sender, EventArgs e)
        {
            Beheergebruiker bg = new Beheergebruiker();
            bg.Show();
        }
    }
}
