using System;
using System.Windows.Forms;

namespace BeheerSysteem
{
    public partial class AdminCP : Form
    {
        private EventClasses.Login val;
        public AdminCP(EventClasses.Login val)
        {
            this.val = val;
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
            FormGebruikersBeheer gb = new FormGebruikersBeheer(val);
            gb.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            EventBeheer eb = new EventBeheer(val);
            eb.Show();
        }

        private void btnMateriaal_Click(object sender, EventArgs e)
        {
            Materiaalbeheer mb = new Materiaalbeheer(val);
            mb.Show();
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            Beheerverhuur vb = new Beheerverhuur(val);
            vb.Show();
        }

        private void btnGroep_Click(object sender, EventArgs e)
        {
            Beheergroep bg = new Beheergroep(val);
            bg.Show();
        }

        private void btnReservering_Click(object sender, EventArgs e)
        {
            Beheerreservering br = new Beheerreservering(val);
            br.Show();
        }
    }
}
