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
    public partial class Materiaalbeheer : Form
    {
        private EventClasses.Login val;
        private Materiaalcontrole mc = new Materiaalcontrole();

        public Materiaalbeheer()
        {
            InitializeComponent();
        }

        public Materiaalbeheer(EventClasses.Login val)
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
                dataGridView1.DataSource = geenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text != "")
            {
            List<EventClasses.Object> Geenproductnaam = mc.Geenproductnaam(Merk, Type);
            dataGridView1.DataSource = Geenproductnaam;
            }

            else if (TbType.Text == "" && TbProductnaam.Text != "" && TbMerk.Text != "")
            {
                List<EventClasses.Object> Geentype = mc.Geentype(Merk, Productnaam);
                dataGridView1.DataSource = Geentype;
            }

            else if (TbProductnaam.Text == "" && TbType.Text == "" && TbMerk.Text != "")
            {
                List<EventClasses.Object> Alleenmerk = mc.Alleenmerk(Merk);
                dataGridView1.DataSource = Alleenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text == "")
            {
                List<EventClasses.Object> Alleentype = mc.Alleentype(Type);
                dataGridView1.DataSource = Alleentype;
            }

            else if (TbProductnaam.Text != "" && TbType.Text == "" && TbMerk.Text == "")
            {
                List<EventClasses.Object> Alleenproductnaam = mc.Alleenproductnaam(Productnaam);
                dataGridView1.DataSource = Alleenproductnaam;
            }

            else if (TbProductnaam.Text != "" && TbType.Text != "" && TbMerk.Text != "")
            {
                List<EventClasses.Object> Alles = mc.Alles(Productnaam , Merk , Type);
                dataGridView1.DataSource = Alles;
            }

        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TbProductnaam.Text = "";
            TbMerk.Text = "";
            TbType.Text = "";
        }

    }
}
