using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
using Object = EventClasses.Object;

namespace BeheerSysteem
{
    public partial class Materiaalbeheer : Form
    {
        private readonly Materiaalcontrole _mc = new Materiaalcontrole();

        public Materiaalbeheer()
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
                dataGridView1.DataSource = geenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text != "")
            {
            List<Object> geenproductnaam = _mc.Geenproductnaam(merk, type);
            dataGridView1.DataSource = geenproductnaam;
            }

            else if (TbType.Text == "" && TbProductnaam.Text != "" && TbMerk.Text != "")
            {
                List<Object> geentype = _mc.Geentype(merk, productnaam);
                dataGridView1.DataSource = geentype;
            }

            else if (TbProductnaam.Text == "" && TbType.Text == "" && TbMerk.Text != "")
            {
                List<Object> alleenmerk = _mc.Alleenmerk(merk);
                dataGridView1.DataSource = alleenmerk;
            }

            else if (TbProductnaam.Text == "" && TbType.Text != "" && TbMerk.Text == "")
            {
                List<Object> alleentype = _mc.Alleentype(type);
                dataGridView1.DataSource = alleentype;
            }

            else if (TbProductnaam.Text != "" && TbType.Text == "" && TbMerk.Text == "")
            {
                List<Object> alleenproductnaam = _mc.Alleenproductnaam(productnaam);
                dataGridView1.DataSource = alleenproductnaam;
            }

            else if (TbProductnaam.Text != "" && TbType.Text != "" && TbMerk.Text != "")
            {
                List<Object> alles = _mc.Alles(productnaam , merk , type);
                dataGridView1.DataSource = alles;
            }

        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TbProductnaam.Text = "";
            TbMerk.Text = "";
            TbType.Text = "";
            dataGridView1.DataSource = null;
        }

        private void BtnBeheer_Click(object sender, EventArgs e)
        {
            Beheermateriaal bm = new Beheermateriaal();
            bm.Show();

    }
    }
}
