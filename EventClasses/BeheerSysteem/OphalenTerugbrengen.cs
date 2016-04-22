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
    public partial class OphalenTerugbrengen : Form
    {
        private EventClasses.Login Val;
        private Verhuurcontrole vc = new Verhuurcontrole();
        public OphalenTerugbrengen(EventClasses.Login val)
        {
            Val = val;
            InitializeComponent();
            listBox1.DataSource = vc.GetReserved();
            listBox2.DataSource = vc.GetBorrowed();
        }
    }
}
