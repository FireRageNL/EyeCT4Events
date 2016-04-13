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
    public partial class EventDialog : Form
    {
        private EventClasses.Login val;
        private bool newevent;
        private EventBeheerder em = new EventBeheerder();
        public EventDialog(EventClasses.Login val, bool b)
        {
            InitializeComponent();
            this.val = val;
            newevent = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbLand.Text) && !string.IsNullOrWhiteSpace(tbNaam.Text) &&
                !string.IsNullOrWhiteSpace(tbNr.Text) && !string.IsNullOrWhiteSpace(tbPlaats.Text)
                && !string.IsNullOrWhiteSpace(tbPost.Text) && !string.IsNullOrWhiteSpace(tbStraat.Text))
            {
                string land = tbLand.Text;
                string naam = tbNaam.Text;
                int nr;
                if (!int.TryParse(tbNr.Text, out nr))
                {
                    MessageBox.Show("Voer alleen nummers in a.u.b.");
                    nr = 0;
                }
                string plaats = tbPlaats.Text;
                string postcode = tbPost.Text;
                string straat = tbStraat.Text;
                string toe = null;
                if (!string.IsNullOrWhiteSpace(tbToev.Text))
                {
                    toe = tbToev.Text;
                }
                DateTime begin = dateTimePicker1.Value.Date;
                DateTime end = dateTimePicker2.Value.Date;

                if (nr != 0)
                {
                    em.AddEvent(straat, nr, toe, plaats, postcode, land, naam, begin, end);
                    this.Dispose();
                }
            }

        }
    }
}
