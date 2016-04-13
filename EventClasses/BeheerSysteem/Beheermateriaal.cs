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
            EventClasses.Object todelete = (EventClasses.Object)listBox1.SelectedItem;
            mc.ToDelete(todelete);

            List<EventClasses.Object> Beheer = mc.Beheer();
            listBox1.DataSource = Beheer;
        }
    }
}
