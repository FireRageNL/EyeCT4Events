﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toegangscontrole
{
    public partial class Gebruikerslijst : Form
    {
        private EventClasses.Toegangscontrole tc = new EventClasses.Toegangscontrole();

        public Gebruikerslijst(int evt)
        {
            InitializeComponent();
            List<string> aanwezig = tc.GetAanwezigheid(evt);
            lbAanwezigheid.DataSource = aanwezig;
        }
    }
}
