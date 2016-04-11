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
        static DAL Start = new DAL();
        DBAdmin DatabaseAdmin = new DBAdmin(Start);

        public Materiaalbeheer()
        {
            InitializeComponent();
        }

        private void BtnZoeken_Click(object sender, EventArgs e)
        {
            string Merk = TbMerk.Text;
            string Productnaam = TbProductnaam.Text;
            string Type = TbType.Text;

            if (TbMerk.Text == "")
            {
                string dbcommandzoeken = "select * from Materiaal where Productnaam ='" + Productnaam + "'" + "and Type ='" + Type + "'";
                DatabaseAdmin.SendDbCommandvoid(dbcommandzoeken);
            }

            else if (TbProductnaam.Text == "")
            {
                string dbcommandzoeken = "select * from Materiaal where Merk ='" + Merk + "'" + "and Type ='" + Type + "'";
                DatabaseAdmin.SendDbCommandvoid(dbcommandzoeken);
            }

            else if (TbType.Text == "")
            {
                string dbcommandzoeken = "select * from Materiaal where Merk ='" + Merk + "'" + "and Type ='" + Productnaam + "'";
                DatabaseAdmin.SendDbCommandvoid(dbcommandzoeken);
            }

            //List<EventClasses.Object> materiaal = new List<EventClasses.Object>();
            //EventClasses.Object o = new EventClasses.Object(int objid, string objproductname, string objbrand, string objtype, string objdescription, decimal objrentprice);
            //materiaal.Add(o);
            //dataGridView1.DataSource = materiaal;
            
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TbProductnaam.Text = "";
            TbMerk.Text = "";
            TbType.Text = "";
        }

    }
}
