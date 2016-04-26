using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
using Object = EventClasses.Object;

namespace BeheerSysteem
{
    public partial class Beheerverhuur : Form
    {
        private readonly Materiaalcontrole _mc = new Materiaalcontrole();
        private readonly Gebruikercontrole _gc = new Gebruikercontrole();
        private readonly Verhuurcontrole _vc = new Verhuurcontrole();

        public Beheerverhuur()
        {
            InitializeComponent();
        }

        private void BtnZoeken_Click(object sender, EventArgs e)
        {
            string merk = TbMerk.Text;
            string productnaam = TbProductnaam.Text;

            int type;
            int.TryParse(TbType.Text, out type);

            if (TbMerk.Text == "" && TbProductnaam.Text != "" && TbType.Text != "")
            {
                List<Object> geenmerk = _mc.Geenmerk(productnaam, type);
                LBMateriaal.DataSource = geenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text != "")
            {
                List<Object> geenproductnaam = _mc.Geenproductnaam(merk, type);
                LBMateriaal.DataSource = geenproductnaam;
            }

            else if (TbType.Text == "" && TbProductnaam.Text != "" && TbMerk.Text != "")
            {
                List<Object> geentype = _mc.Geentype(merk, productnaam);
                LBMateriaal.DataSource = geentype;
            }

            else if (TbProductnaam.Text == "" && TbType.Text == "" && TbMerk.Text != "")
            {
                List<Object> alleenmerk = _mc.Alleenmerk(merk);
                LBMateriaal.DataSource = alleenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text == "")
            {
                List<Object> alleentype = _mc.Alleentype(type);
                LBMateriaal.DataSource = alleentype;
            }

            else if (TbProductnaam.Text != "" && TbType.Text == "" && TbMerk.Text == "")
            {
                List<Object> alleenproductnaam = _mc.Alleenproductnaam(productnaam);
                LBMateriaal.DataSource = alleenproductnaam;
            }

            else if (TbProductnaam.Text != "" && TbType.Text != "" && TbMerk.Text != "")
            {
                List<Object> alles = _mc.Alles(productnaam, merk, type);
                LBMateriaal.DataSource = alles;
            }
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TbProductnaam.Text = "";
            TbMerk.Text = "";
            TbType.Text = "";
            LBMateriaal.DataSource = null;
        }

        private void BtnGebZoek_Click(object sender, EventArgs e)
        {
            string achternaam = TbAchternaam.Text;
            string email = TbEmail.Text;
            string datum = TbDatum.Text;


            if (TbAchternaam.Text == "" && TbEmail.Text != "" && TbDatum.Text != "")
            {
                List<User> geenachternaam = _gc.Geenachternaam(email, datum);
                LBGebruikers.DataSource = geenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<User> geenachternaam = _gc.Geenemail(achternaam, datum);
                LBGebruikers.DataSource = geenachternaam;
            }

            else if (TbDatum.Text == "" && TbEmail.Text != "" && TbAchternaam.Text != "")
            {
                List<User> geendatum = _gc.Geendatum(achternaam, email);
                LBGebruikers.DataSource = geendatum;
            }

            else if (TbEmail.Text == "" && TbDatum.Text == "" && TbAchternaam.Text != "")
            {
                List<User> alleenachternaam = _gc.Alleenachternaam(achternaam);
                LBGebruikers.DataSource = alleenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text == "")
            {
                List<User> alleendatum = _gc.Alleendatum(datum);
                LBGebruikers.DataSource = alleendatum;
            }

            else if (TbEmail.Text != "" && TbDatum.Text == "" && TbAchternaam.Text == "")
            {
                List<User> alleenachternaam = _gc.Alleenemail(email);
                LBGebruikers.DataSource = alleenachternaam;
            }

            else if (TbEmail.Text != "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<User> alles = _gc.Alles(achternaam, email, datum);
                LBGebruikers.DataSource = alles;
            }
        }

        private void BtnBevestigen_Click(object sender, EventArgs e)
        {

            User selectUser = (User)LBGebruikers.SelectedItem;
            Object selectMateriaal = (Object)LBMateriaal.SelectedItem;
            DateTime beginDatum = DTPBegin.Value;
            DateTime eindDatum = DTPEind.Value;
            DateTime nuDatum = DateTime.Now;
            bool opgehaald = CbOpgehaald.Checked;


            int huur = _vc.Huur(selectMateriaal, selectUser, beginDatum, eindDatum, nuDatum , opgehaald);

            switch (huur)
            {
                case 1:
                    MessageBox.Show("Materiaal niet beschiktbaar op begin datum");
                    break;
                case 2:
                    MessageBox.Show("Materiaal niet beschiktbaar op einddatum datum");
                    break;
                case 3:
                    MessageBox.Show("Reservering is bevestigt");
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OphalenTerugbrengen ot = new OphalenTerugbrengen();
            ot.ShowDialog();
        }
    }
}
