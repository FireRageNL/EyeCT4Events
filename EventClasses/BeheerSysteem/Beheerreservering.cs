using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;
namespace BeheerSysteem
{
    public partial class Beheerreservering : Form
    {
        private EventClasses.Login Val;
        private ReserveringControl rc = new ReserveringControl();
        private Group searchgroup;
        public Beheerreservering(EventClasses.Login val)
        {
            Val = val;
            InitializeComponent();
            List<Group> data = new List<Group>();
            data = rc.GetEmptyGroups();
            listBox1.DataSource = data;
            btnReserveer.Enabled = false;
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            searchgroup = (Group) listBox1.SelectedItem;
            List<EventClasses.Location> freeLocations = new List<Location>();
            freeLocations = rc.GetFreeLocations(searchgroup.Users.Count);
            listBox2.DataSource = freeLocations;
            btnReserveer.Enabled = true;
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            Location reserve = (Location) listBox2.SelectedItem;
            rc.ReserveLocation(searchgroup, reserve);
            listBox2.DataSource = null;
            listBox1.DataSource = null;
            List<Group> data = new List<Group>();
            data = rc.GetEmptyGroups();
            listBox1.DataSource = data;
            btnReserveer.Enabled = false;
        }
    }
}
