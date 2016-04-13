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
    }
}
