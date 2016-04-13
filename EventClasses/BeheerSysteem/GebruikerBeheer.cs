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
    public partial class FormGebruikersBeheer : Form
    {
        private EventClasses.Login val;
        private Gebruikercontrole mc = new Gebruikercontrole();

        public FormGebruikersBeheer()
        {
            InitializeComponent();
        }

        public FormGebruikersBeheer(EventClasses.Login val)
        {
            InitializeComponent();
            this.val = val;
        }
        private void BtnZoeken_Click(object sender, EventArgs e)
        {
            string achternaam = TbAchternaam.Text;
            string email = TbEmail.Text;
            string datum = TbDatum.Text;


            if (TbAchternaam.Text == "" && TbEmail.Text != "" && TbDatum.Text != "")
            {
                List<EventClasses.User> geenachternaam = mc.Geenachternaam(email, datum);
                dataGridView1.DataSource = geenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Geenachternaam = mc.Geenemail(achternaam, datum);
                dataGridView1.DataSource = Geenachternaam;
            }

            else if (TbDatum.Text == "" && TbEmail.Text != "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Geendatum = mc.Geendatum(achternaam, email);
                dataGridView1.DataSource = Geendatum;
            }

            else if (TbEmail.Text == "" && TbDatum.Text == "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Alleenachternaam = mc.Alleenachternaam(achternaam);
                dataGridView1.DataSource = Alleenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text == "")
            {
                List<EventClasses.User> Alleendatum = mc.Alleendatum(datum);
                dataGridView1.DataSource = Alleendatum;
            }

            else if (TbEmail.Text != "" && TbDatum.Text == "" && TbAchternaam.Text == "")
            {
                List<EventClasses.User> Alleenachternaam = mc.Alleenemail(email);
                dataGridView1.DataSource = Alleenachternaam;
            }

            else if (TbEmail.Text != "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Alles = mc.Alles(achternaam, email, datum);
                dataGridView1.DataSource = Alles;
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
            Beheergebruiker bg = new Beheergebruiker(val);
            bg.Show();
        }
    }
}
