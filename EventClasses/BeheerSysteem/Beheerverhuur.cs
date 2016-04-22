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
    public partial class Beheerverhuur : Form
    {
        private EventClasses.Login val;
        private Materiaalcontrole mc = new Materiaalcontrole();
        private Gebruikercontrole gc = new Gebruikercontrole();
        private Verhuurcontrole vc = new Verhuurcontrole();

        public Beheerverhuur(EventClasses.Login val)
        {
            InitializeComponent();
            this.val = val;
        }

        private void BtnZoeken_Click(object sender, EventArgs e)
        {
            string Merk = TbMerk.Text;
            string Productnaam = TbProductnaam.Text;

            int Type;
            int.TryParse(TbType.Text, out Type);

            if (TbMerk.Text == "" && TbProductnaam.Text != "" && TbType.Text != "")
            {
                List<EventClasses.Object> geenmerk = mc.Geenmerk(Productnaam, Type);
                LBMateriaal.DataSource = geenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text != "")
            {
                List<EventClasses.Object> Geenproductnaam = mc.Geenproductnaam(Merk, Type);
                LBMateriaal.DataSource = Geenproductnaam;
            }

            else if (TbType.Text == "" && TbProductnaam.Text != "" && TbMerk.Text != "")
            {
                List<EventClasses.Object> Geentype = mc.Geentype(Merk, Productnaam);
                LBMateriaal.DataSource = Geentype;
            }

            else if (TbProductnaam.Text == "" && TbType.Text == "" && TbMerk.Text != "")
            {
                List<EventClasses.Object> Alleenmerk = mc.Alleenmerk(Merk);
                LBMateriaal.DataSource = Alleenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text == "")
            {
                List<EventClasses.Object> Alleentype = mc.Alleentype(Type);
                LBMateriaal.DataSource = Alleentype;
            }

            else if (TbProductnaam.Text != "" && TbType.Text == "" && TbMerk.Text == "")
            {
                List<EventClasses.Object> Alleenproductnaam = mc.Alleenproductnaam(Productnaam);
                LBMateriaal.DataSource = Alleenproductnaam;
            }

            else if (TbProductnaam.Text != "" && TbType.Text != "" && TbMerk.Text != "")
            {
                List<EventClasses.Object> Alles = mc.Alles(Productnaam, Merk, Type);
                LBMateriaal.DataSource = Alles;
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
                List<EventClasses.User> geenachternaam = gc.Geenachternaam(email, datum);
                LBGebruikers.DataSource = geenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Geenachternaam = gc.Geenemail(achternaam, datum);
                LBGebruikers.DataSource = Geenachternaam;
            }

            else if (TbDatum.Text == "" && TbEmail.Text != "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Geendatum = gc.Geendatum(achternaam, email);
                LBGebruikers.DataSource = Geendatum;
            }

            else if (TbEmail.Text == "" && TbDatum.Text == "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Alleenachternaam = gc.Alleenachternaam(achternaam);
                LBGebruikers.DataSource = Alleenachternaam;
            }

            else if (TbEmail.Text == "" && TbDatum.Text != "" && TbAchternaam.Text == "")
            {
                List<EventClasses.User> Alleendatum = gc.Alleendatum(datum);
                LBGebruikers.DataSource = Alleendatum;
            }

            else if (TbEmail.Text != "" && TbDatum.Text == "" && TbAchternaam.Text == "")
            {
                List<EventClasses.User> Alleenachternaam = gc.Alleenemail(email);
                LBGebruikers.DataSource = Alleenachternaam;
            }

            else if (TbEmail.Text != "" && TbDatum.Text != "" && TbAchternaam.Text != "")
            {
                List<EventClasses.User> Alles = gc.Alles(achternaam, email, datum);
                LBGebruikers.DataSource = Alles;
            }
        }

        private void BtnBevestigen_Click(object sender, EventArgs e)
        {

            EventClasses.User SelectUser = (EventClasses.User)LBGebruikers.SelectedItem;
            EventClasses.Object SelectMateriaal = (EventClasses.Object)LBMateriaal.SelectedItem;
            DateTime BeginDatum = DTPBegin.Value;
            DateTime EindDatum = DTPEind.Value;
            DateTime NuDatum = DateTime.Now;
            bool Opgehaald = CbOpgehaald.Checked;
            bool Teruggebracht = false;


            int huur = vc.Huur(SelectMateriaal, SelectUser, BeginDatum, EindDatum, NuDatum , Opgehaald, Teruggebracht);

            if (huur == 1)
            {
                MessageBox.Show("Materiaal niet beschiktbaar op begin datum");
            }
            else if (huur == 2)
            {
                MessageBox.Show("Materiaal niet beschiktbaar op einddatum datum");
            }

            else if (huur == 3)
            {
                MessageBox.Show("Reservering is bevestigt");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OphalenTerugbrengen ot = new OphalenTerugbrengen(val);
            ot.ShowDialog();
        }
    }
}
