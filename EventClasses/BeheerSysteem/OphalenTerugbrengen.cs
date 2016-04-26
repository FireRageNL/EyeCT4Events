using System;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class OphalenTerugbrengen : Form
    {
        private readonly Verhuurcontrole _vc = new Verhuurcontrole();
        public OphalenTerugbrengen()
        {
            InitializeComponent();
            listBox1.DataSource = _vc.GetReserved();
            listBox2.DataSource = _vc.GetBorrowed();
        }

        private void btnGeefUit_Click(object sender, EventArgs e)
        {
            ObjectReservation res = (ObjectReservation)listBox1.SelectedItem;
            _vc.Borrow(res);
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _vc.GetReserved();
            listBox2.DataSource = _vc.GetBorrowed();
        }

        private void btnNeemTerug_Click(object sender, EventArgs e)
        {
            ObjectReservation res = (ObjectReservation) listBox2.SelectedItem;
            _vc.TakeBack(res);
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _vc.GetReserved();
            listBox2.DataSource = _vc.GetBorrowed();
        }
    }
}
