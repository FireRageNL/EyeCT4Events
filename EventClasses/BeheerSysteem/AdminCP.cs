using System;
using System.Windows.Forms;

namespace BeheerSysteem
{
    public partial class AdminCp : Form
    {
        public AdminCp(EventClasses.Login val)
        {
            InitializeComponent();
            if (val.AccessLevel == 1)
            {
                btnGebruiker.Enabled = false;
                btnEvent.Enabled = false;
                btnGroep.Enabled = false;
                btnReservering.Enabled = false;
            }
        }

        private void btnGebruiker_Click(object sender, EventArgs e)
        {
            FormGebruikersBeheer gb = new FormGebruikersBeheer();
            gb.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            EventBeheer eb = new EventBeheer();
            eb.Show();
        }

        private void btnMateriaal_Click(object sender, EventArgs e)
        {
            Materiaalbeheer mb = new Materiaalbeheer();
            mb.Show();
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            Beheerverhuur vb = new Beheerverhuur();
            vb.Show();
        }

        private void btnGroep_Click(object sender, EventArgs e)
        {
            Beheergroep bg = new Beheergroep();
            bg.Show();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            Beheerreservering br = new Beheerreservering();
            br.Show();
        }
    }
}
