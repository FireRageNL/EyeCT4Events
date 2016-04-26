using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class Beheerreservering : Form
    {
        private readonly ReserveringControl _rc = new ReserveringControl();
        private Group _searchgroup;
        public Beheerreservering()
        {
            InitializeComponent();
            List<Group> data = _rc.GetEmptyGroups();
            listBox1.DataSource = data;
            btnReserveer.Enabled = false;
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            _searchgroup = (Group) listBox1.SelectedItem;
            List<Location> freeLocations = _rc.GetFreeLocations(_searchgroup.Users.Count);
            listBox2.DataSource = freeLocations;
            btnReserveer.Enabled = true;
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            Location reserve = (Location) listBox2.SelectedItem;
            _rc.ReserveLocation(_searchgroup, reserve);
            listBox2.DataSource = null;
            listBox1.DataSource = null;
            List<Group> data = _rc.GetEmptyGroups();
            listBox1.DataSource = data;
            btnReserveer.Enabled = false;
        }
    }
}
