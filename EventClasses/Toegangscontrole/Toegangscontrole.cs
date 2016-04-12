﻿using System;
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
            string[] eventnaam = tc.GetEvents();

            int length = eventnaam.Length - 1;
            for (int i = 0; i <= length; i++)
            {
                CbEvent.Items.Add(eventnaam[i]);
            }
            this.val = val;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int RFID;
            int.TryParse(TbRFID.Text, out RFID);

           CheckIn check= tc.CheckIn(RFID);
            LblNaam.Text = check.Naam;
            ChkBetaald.Checked = check.Betaald;

            if (check.Betaald == false)
            {
                MessageBox.Show("Bezoeker heeft nog niet betaald");
            }
        }

        private void BtnBetaald_Click(object sender, EventArgs e)
        {
            int RFID;
            int.TryParse(TbRFID.Text, out RFID);
            Boolean check = tc.Betaald(RFID);
            ChkBetaald.Checked = check;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TbRFID.Text = "";
            LblNaam.Text = "";
            ChkBetaald.Checked = false;
        }

        private void CbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
