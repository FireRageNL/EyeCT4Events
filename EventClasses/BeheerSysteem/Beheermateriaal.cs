using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
using Object = EventClasses.Object;

namespace BeheerSysteem
{
    public partial class Beheermateriaal : Form
    {
        private readonly Materiaalcontrole _mc = new Materiaalcontrole();
        public Beheermateriaal()
        {
            InitializeComponent();
            List<Object> beheerMateriaal = _mc.BeheerMateriaal();
            listBox1.DataSource = beheerMateriaal;
        }

        private void BtnVerwijder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Weet je zeker dat je dit object wilt verwijderen?", "Waarschuwing!",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Object deleteMateriaal = (Object) listBox1.SelectedItem;
                _mc.DeleteMateriaal(deleteMateriaal);
            }
            List<Object> beheerMateriaal = _mc.BeheerMateriaal();
            listBox1.DataSource = beheerMateriaal;
        }

        private void BtnWijzigen_Click(object sender, EventArgs e)
        {
            Object updateMateriaal = (Object)listBox1.SelectedItem;
            MateriaalDialog dia = new MateriaalDialog(false, updateMateriaal);
            dia.ShowDialog();
            List<Object> beheerMateriaal = _mc.BeheerMateriaal();
            listBox1.DataSource = beheerMateriaal;
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            MateriaalDialog dia = new MateriaalDialog(true);
            dia.ShowDialog();
            List<Object> beheerMateriaal = _mc.BeheerMateriaal();
            listBox1.DataSource = beheerMateriaal;
        }
    }
}
