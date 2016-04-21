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
    public partial class Beheergroep : Form
    {
        private EventClasses.Login Val;
        private GroepControl gc = new GroepControl();
        public Beheergroep(EventClasses.Login val)
        {   
            InitializeComponent();
            Val = val;
            listBox1.DataSource = gc.GetUsers();
            listBox1.DisplayMember = "GroupName";
        }
    }
}
