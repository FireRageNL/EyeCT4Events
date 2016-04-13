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
    public partial class Beheermateriaal : Form
    {
        private EventClasses.Login val;
        private Materiaalcontrole mc = new Materiaalcontrole();
        public Beheermateriaal(EventClasses.Login val)
        {
            InitializeComponent();
            this.val = val;
            List<EventClasses.Object> Beheer = mc.Beheer();
            listBox1.DataSource = Beheer;
        }

        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je dit object wilt verwijderen?", "Waarschuwing!",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EventClasses.Object todelete = (EventClasses.Object) listBox1.SelectedItem;
                mc.ToDelete(todelete);
            }
            List<EventClasses.Object> Beheer = mc.Beheer();
            listBox1.DataSource = Beheer;
        }

        private void BtnWijzigen_Click(object sender, EventArgs e)
        {
            EventClasses.Object toUpdate = (EventClasses.Object)listBox1.SelectedItem;
            MateriaalDialog dia = new MateriaalDialog(val,false,toUpdate);
            dia.ShowDialog();
            List<EventClasses.Object> Beheer = mc.Beheer();
            listBox1.DataSource = Beheer;
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            MateriaalDialog dia = new MateriaalDialog(val,true);
            dia.ShowDialog();
            List<EventClasses.Object> Beheer = mc.Beheer();
            listBox1.DataSource = Beheer;
        }
    }
}
