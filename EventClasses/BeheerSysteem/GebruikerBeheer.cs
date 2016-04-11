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
    public partial class FormGebruikersBeheer : Form
    {
        private EventClasses.Login val;

        public FormGebruikersBeheer()
        {
            InitializeComponent();
        }

        public FormGebruikersBeheer(EventClasses.Login val)
        {
            InitializeComponent();
            this.val = val;
        }
    }
}
