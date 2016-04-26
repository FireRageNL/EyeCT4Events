using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class EventBeheer : Form
    {
        private readonly EventBeheerder _em = new EventBeheerder();
        public EventBeheer()
        {
            InitializeComponent();
            List<Event> evt = _em.GetEvents();
            listBox1.DataSource = evt;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EventDialog dia = new EventDialog();
            dia.ShowDialog();
            List<Event> evt = _em.GetEvents();
            listBox1.DataSource = evt;
        }
    }
}
