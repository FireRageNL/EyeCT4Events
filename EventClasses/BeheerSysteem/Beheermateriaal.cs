using System;
using System.Collections.Generic;
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
            List<EventClasses.Object> BeheerMateriaal = mc.BeheerMateriaal();
            listBox1.DataSource = BeheerMateriaal;
        }

        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je dit object wilt verwijderen?", "Waarschuwing!",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                EventClasses.Object DeleteMateriaal = (EventClasses.Object) listBox1.SelectedItem;
                mc.DeleteMateriaal(DeleteMateriaal);
            }
            List<EventClasses.Object> BeheerMateriaal = mc.BeheerMateriaal();
            listBox1.DataSource = BeheerMateriaal;
        }

        private void BtnWijzigen_Click(object sender, EventArgs e)
        {
            EventClasses.Object UpdateMateriaal = (EventClasses.Object)listBox1.SelectedItem;
            MateriaalDialog dia = new MateriaalDialog(val,false, UpdateMateriaal);
            dia.ShowDialog();
            List<EventClasses.Object> BeheerMateriaal = mc.BeheerMateriaal();
            listBox1.DataSource = BeheerMateriaal;
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            MateriaalDialog dia = new MateriaalDialog(val,true);
            dia.ShowDialog();
            List<EventClasses.Object> BeheerMateriaal = mc.BeheerMateriaal();
            listBox1.DataSource = BeheerMateriaal;
        }
    }
}
