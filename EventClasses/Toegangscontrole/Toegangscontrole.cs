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

namespace Toegangscontrole
{
    public partial class Toegangscontrole : Form
    {
        private EventClasses.Toegangscontrole tc = new EventClasses.Toegangscontrole();
        private EventClasses.Login val;

        public Toegangscontrole()
        {
            InitializeComponent();
        }

        public Toegangscontrole(EventClasses.Login val)
        {
            InitializeComponent();
            this.val = val;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int RFID;
            int.TryParse(TbRFID.Text, out RFID);
            string naam = LblNaam.Text;

           CheckIn check= tc.CheckIn(RFID);
         

            if (check.Betaald == false)
            {
                MessageBox.Show("Bezoeker heeft nog niet betaald");
            }
        }
    }
}
