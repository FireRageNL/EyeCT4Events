using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class EventBeheer : Form
    {
        private EventClasses.Login val;
        private EventBeheerder em = new EventBeheerder();
        public EventBeheer(EventClasses.Login val)
        {
            this.val = val;
            InitializeComponent();
            List<Event> evt = em.GetEvents();
            listBox1.DataSource = evt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EventDialog dia = new EventDialog(val, true);
            dia.ShowDialog();
            List<Event> evt = em.GetEvents();
            listBox1.DataSource = evt;
        }
    }
}
